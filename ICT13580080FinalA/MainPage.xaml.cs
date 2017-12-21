using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580080FinalA
{
    public partial class MainPage : ContentPage
    {
		public MainPage()
		{
			InitializeComponent();

            Newww.Clicked += NewButton_Clicked;


		}

		protected override void OnAppearing()
		{
			
		}

		void LoadData()
		{
			
		}

		void NewButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new ProductNewPage());
		}
	}
}
