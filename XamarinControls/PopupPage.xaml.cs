﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupPage : ContentPage
    {
        public PopupPage()
        {
            InitializeComponent();
        }

        private void popupBtn_Clicked(object sender, EventArgs e)
        {
            Popup.IsVisible = true;
        }

        private void CloseBtn_Clicked(object sender, EventArgs e)
        {
            Popup.IsVisible = false;
        }
    }
}