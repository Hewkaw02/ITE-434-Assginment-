using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TNI1911310512
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // How to change page application

            // NavicationPage
            var page1 = new NavPage1();
            var np = new NavigationPage(page1);

            // Tabbed Page 
            var tp = new TabbedPage();
            tp.Children.Add(new TabPage1());
            tp.Children.Add(new TabPage2());
            tp.Children.Add(new TabPage3());

            // EventPage
            var Event = new EventPage1();
            var ev = new NavigationPage(Event);
            

            
            

            MainPage = ev;
            

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
