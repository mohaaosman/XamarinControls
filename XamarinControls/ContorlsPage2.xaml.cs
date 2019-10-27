using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContorlsPage2 : ContentPage
	{
		public ContorlsPage2 ()
		{
			InitializeComponent ();

            MyImg.Source = ImageSource.FromResource("XamarinControls.Assets.pic1.PNG");
            send_btn.Text = Lang.lang.send_btn;
            info_Label.Text = Lang.lang.info_Label;

            TapGestureRecognizer ImgTap = new TapGestureRecognizer();
            ImgTap.Tapped += ImgTap_Tapped;

            MyImg.GestureRecognizers.Add(ImgTap);
        }

        private void ImgTap_Tapped(object sender, EventArgs e)
        {
            MyImg.Source = ImageSource.FromResource("XamarinControls.Assets.pic2.PNG");
            this.BackgroundColor = Color.DimGray;
            info_Label.Text = "has been changed";
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                this.BackgroundColor = Color.Blue;
            }
            else
            {
                this.BackgroundColor = Color.Default;
            }
        }

        private void getTxt_Clicked(object sender, EventArgs e)
        {
            mypicker.Items.Add(myTxt.Text);
            myTxt.Text = "";
        }
    }
}