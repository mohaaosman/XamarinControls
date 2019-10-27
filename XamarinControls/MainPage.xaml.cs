using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinControls
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabPage());
        }

        private async void btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CarsuPage());
        }

        private async void btn3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage());
        }

        private async void btn4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MasterPage());
        }

        private async void btn5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void btn6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ControlsPage1());
        }

        private async void btn7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WebViewPage());
        }

        private async void btn8_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MediaPage());
        }

        private async void btn9_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContorlsPage2());
        }

        private async void btn10_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PopupPage());
        }

        private async void btn11_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridStylePage());
        }
    }
}
