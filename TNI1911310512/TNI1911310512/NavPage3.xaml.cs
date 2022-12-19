using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TNI1911310512
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavPage3 : ContentPage
	{
		public NavPage3 ()
		{
			InitializeComponent ();

            ClosePage.Clicked += ClosePage_Clicked;
		}

        private void ClosePage_Clicked(object sender, EventArgs e)
        {

			Navigation.PopModalAsync ();

        }
    }
}