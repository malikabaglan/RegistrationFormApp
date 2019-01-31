using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RegistrationForm;
using SQLite;
using Xamarin.Forms;
//[assembly: Xamarin.Forms.Dependency(typeof(CustomersDataAccess))]
namespace RegistrationForm
{
    public class CustomersDataAccess
    {
        private SQLiteConnection database;
        private static object collisionLock = new object();

        public ObservableCollection<Customer> Customers { get; set; }
   
    public CustomersDataAccess()
        {
     database =DependencyService.Get<IDatabaseConnection>(). //`DependencyService.Get().GetConnection();

           // database = DependencyService.Get<IDatabaseConnection>().DbConnection();
           DbConnection();
            database.CreateTable<Customer>();
            this.Customers =
              new ObservableCollection<Customer>(database.Table<Customer>());
            // If the table is empty, initialize the collection
            if (!database.Table<Customer>().Any())
            {
                AddNewCustomer();
            }
}
        public void AddNewCustomer()
        {
            this.Customers.
              Add(new Customer
              {
                  CompanyName = "License Title/Agency...",
                  PhysicalAddress = "Name on The License...",
                  Country = "License Number..."
              });
        }
        public IEnumerable<Customer> GetFilteredCustomers(string countryName)
        {
            lock (collisionLock)
            {
                var query = from cust in database.Table<Customer>()
                            where cust.Country == countryName
                            select cust;
                return query.AsEnumerable();
            }
        }
        public IEnumerable<Customer> GetFilteredCustomers()
      {
           lock (collisionLock)
           {
              return database.Query<Customer>(
                "SELECT * FROM Item WHERE Country = 'Italy'").AsEnumerable();
        }
       }
        public Customer GetCustomer(int id)
        {
            lock (collisionLock)
            {
                return database.Table<Customer>().
                  FirstOrDefault(customer => customer.Id == id);
            }
        }

        public int SaveCustomer(Customer customerInstance)
        {
            lock (collisionLock)
            {
                if (customerInstance.Id != 0)
                {
                    database.Update(customerInstance);
                    return customerInstance.Id;
                }
                else
                {
                    database.Insert(customerInstance);
                    return customerInstance.Id;
                }
            }
        }
        public void SaveAllCustomers()
        {
            lock (collisionLock)
            {
                foreach (var customerInstance in this.Customers)
                {
                    if (customerInstance.Id != 0)
                    {
                        database.Update(customerInstance);
                    }
                    else
                    {
                        database.Insert(customerInstance);
                    }
                }
            }
        }
        public int DeleteCustomer(Customer customerInstance)
        {
            var id = customerInstance.Id;
            if (id != 0)
            {
                lock (collisionLock)
                {
                    database.Delete<Customer>(id);
                }
            }
            this.Customers.Remove(customerInstance);
            return id;
        }

        public void DeleteAllCustomers()
        {
            lock (collisionLock)
            {
                database.DropTable<Customer>();
                database.CreateTable<Customer>();
            }
            this.Customers = null;
            this.Customers = new ObservableCollection<Customer>
              (database.Table<Customer>());
        }


    }



}
