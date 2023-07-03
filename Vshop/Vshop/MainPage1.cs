using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Vshop
{
	public class MainPage1 : ContentPage
	{
		public MainPage1 ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Xamarin.Forms!" }
				}
			};
		}
	}
}