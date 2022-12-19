using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TNI1911310512
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            sendName.Clicked += SendName_Clicked;
            sliderValue.ValueChanged += SliderValue_ValueChanged;
            editTextName.TextChanged += EditTextName_TextChanged;
            countStepper.ValueChanged += CountStepper_ValueChanged;
            openSwitch.Toggled += OpenSwitch_Toggled;
            colorPicker.SelectedIndexChanged += ColorPicker_SelectedIndexChanged; 
            
        }

        private void ColorPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            textViewName.Text = colorPicker.SelectedItem.ToString();
        }

        private void OpenSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            textViewName.Text = e.Value.ToString();
        }

        private void CountStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            numStepper.Text = e.NewValue.ToString();
        }

        private void EditTextName_TextChanged(object sender, TextChangedEventArgs e)
        {
            textViewName.Text = editTextName.Text;
        }

        private void SliderValue_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            textViewName.Text = e.NewValue.ToString("N0");
        }

        private void SendName_Clicked(object sender, EventArgs e)
        {
            textViewName.Text = "Hello, " + editTextName.Text + " Value " + sliderValue.Value.ToString("N0");
        }


    }
}
