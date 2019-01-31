using System;
using System.Collections.ObjectModel;
using RegistrationForm.ViewModel;

namespace RegistrationForm
{
    public class MainViewModal
    {
        private Product _oldProduct;

        public ObservableCollection<Product> Products { get; set; }

        public MainViewModal()
        {
            Products = new ObservableCollection<Product>

            {

         new Product

{

        Title = "Pharmacist",
        isVisible=false

},
        new Product

        {

          Title = "Pharmacist Intern",

       },

        new Product

        {

          Title = "Pharmacist Student",

       },




        new Product

        {

          Title = "Pharmacist Techician",

       },

 new Product
    {
            Title = "Pharmacist Techician Intern",

    }

        };
    }

        public void HideOrShowProduct(Product product)
        {

            if (_oldProduct==product)
            {
                //click twice on the same item will hide it
                product.isVisible = !product.isVisible;
                UpdateProducts(product);
            }
            else
            {
                if(_oldProduct!=null)
                {
                    //hide previous selected item 
                    _oldProduct.isVisible = false;
                    UpdateProducts(_oldProduct);

                }
                //show selected item
                product.isVisible = true;
                UpdateProducts(product);
            }
            _oldProduct = product;

            //product.isVisible = true;

            //UpdateProducts(product);
            //_oldProduct = product;
        }

        private void UpdateProducts(Product product)
        {
           var index= Products.IndexOf(product);
            Products.Remove(product);
            Products.Insert(index,product);
        }
    }
}
