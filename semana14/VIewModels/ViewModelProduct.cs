using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace semana14
{
	public class ViewModelProduct: BaseViewModel
	{

		private string color;

		public string Color
		{
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }

        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Product> product;
        public List<Product> People
        {
            get { return this.product; }
            set { SetValue(ref this.product, value); }
        }

        public ICommand SearchCommand { get; set; }

        public ViewModelProduct()
		{
            SearchCommand = new Command(() =>
            {
                ProductService service = new ProductService();

                product = service.GetByText(Filter);
                Console.Write(product.ToString());
            });
		}
	}
}

