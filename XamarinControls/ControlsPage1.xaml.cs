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
	public partial class ControlsPage1 : ContentPage
	{
		public ControlsPage1 ()
		{
			InitializeComponent ();


            string[] Days = { "Sunday", "Monday", "Tuesday" };

            listItems.ItemsSource = Days;
        }

        private void listItems_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Title", "content" + e.SelectedItem.ToString(), "yes", "NO");
        }
    }
}