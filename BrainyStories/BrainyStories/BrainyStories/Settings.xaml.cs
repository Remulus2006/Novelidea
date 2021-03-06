﻿using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrainyStories
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

    // Class for the settings page
	public partial class Settings : PopupPage
	{
		public Settings ()
		{
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
		}

        // Returns to the previous page when return is pressed
        protected override bool OnBackButtonPressed()
        {
            return false;
        }

        // Returns to the previous page when an area outside the popup is clicked
        private async void OnClose(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}