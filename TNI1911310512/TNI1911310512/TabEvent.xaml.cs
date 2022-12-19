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
	public partial class TabEvent : ContentPage
	{
		public TabEvent ()
		{
			InitializeComponent ();

            openPage2.Clicked += OpenPage2_Clicked;
		}

        private void OpenPage2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EventPage2());
        }
    }
}