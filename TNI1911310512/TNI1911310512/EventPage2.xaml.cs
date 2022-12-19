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
	public partial class EventPage2 : ContentPage
	{
		public EventPage2 ()
		{
			InitializeComponent ();



            closePage2.Clicked += ClosePage2_Clicked;
		}

        private void ClosePage2_Clicked(object sender, EventArgs e)
        {
			Navigation.PopModalAsync();
        }
    }
}