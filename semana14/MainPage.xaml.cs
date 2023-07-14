using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using semana14.Views;
using Xamarin.Forms;

namespace semana14
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ProductService service = new ProductService();
            List<Product> product = new List<Product>();

			product.Add(new Product 
			{ 
			    Name = txtName.Text , 
				    Description = txtDescription.Text, 
			    Price = decimal.Parse(txtPrice.Text),
			    DueDate = txtDuedate.Date
			});

            service.CreateRange(product);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductView());
        }

    }
}

