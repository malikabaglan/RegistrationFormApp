using System;
using System.IO;
using RegistrationForm.Droid;
using SQLite;
[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_Android))]
namespace RegistrationForm.Droid
{
    public class DatabaseConnection_Android: IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "CustomersDb.db3";
            var path = Path.Combine(System.Environment.
              GetFolderPath(System.Environment.
              SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }
    }
}

