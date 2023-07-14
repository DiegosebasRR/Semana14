using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductView : ContentPage
	{	
		public ProductView ()
		{
            InitializeComponent();
            this.BindingContext = new ViewModelProduct();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ProductService service = new ProductService();
            lvProduct.ItemsSource = service.Get();
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}

