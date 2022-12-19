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
	public partial class EventPage1 : ContentPage
	{
		public EventPage1 ()
		{
			InitializeComponent ();



            openEventPage2.Clicked += OpenEventPage2_Clicked;
            openTabPage3.Clicked += OpenTabPage3_Clicked;
		}

        private void OpenTabPage3_Clicked(object sender, EventArgs e)
        {
            var tp = new TabbedPage();
            tp.Children.Add(new TabPage1());
            tp.Children.Add(new TabPage2());
            tp.Children.Add(new TabPage3());
            tp.Children.Add(new TabEvent());
            Navigation.PushAsync(tp);
        }

        private void OpenEventPage2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EventPage2());
        }
    }
}