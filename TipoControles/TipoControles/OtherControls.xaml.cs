using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoControles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OtherControls : ContentPage
	{
        bool activeWindow;
		public OtherControls ()
		{
			InitializeComponent ();
            this.progress.Progress = 0;
            this.slider1.ValueChanged += Slider1_ValueChanged;
            this.stepper1.ValueChanged += Stepper1_ValueChanged;
		}

        private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.lblStepper.Text = "Step: " + e.NewValue;
        }

        private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.lblSlider.Text = "Slider: " + e.NewValue;
        }

        bool TimerCallBack()
        {
            this.progress.Progress += 0.01;
            return activeWindow || this.progress.Progress == 1;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            activeWindow = true;
            Device.StartTimer(TimeSpan.FromSeconds(0.1), TimerCallBack);
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            activeWindow = false;
        }
    }
}