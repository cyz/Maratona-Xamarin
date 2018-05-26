using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Modulo2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            this.list.ItemsSource = Models.Item.GetItems();
        }
	}
}
