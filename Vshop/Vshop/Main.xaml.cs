using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vshop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Main : ContentPage
	{
		public Main ()
		{
			InitializeComponent ();
		}
		async void HomePage(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MainPage());
		}
	}
}