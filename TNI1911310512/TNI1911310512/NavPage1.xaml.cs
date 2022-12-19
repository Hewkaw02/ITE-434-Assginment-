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
	public partial class NavPage1 : ContentPage
	{
		public NavPage1 ()
		{
			InitializeComponent ();

            openPage2.Clicked += OpenPage2_Clicked;
            openPage3.Clicked += OpenPage3_Clicked;

		}
               
        private async void OpenPage2_Clicked(object sender, EventArgs e)
        {
            
			await Navigation.PushAsync(new NavPage2 ());

        }

        private async void OpenPage3_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new NavPage3());

        }
    }
}