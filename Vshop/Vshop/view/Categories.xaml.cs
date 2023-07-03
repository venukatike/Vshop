using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vshop.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Categories : ContentPage
    {
        public Categories()
        {
            InitializeComponent();

                lis.ItemsSource = new string[]
                {
            "Dresses",
            "Shoes",
            "KidsWear",
            "MensWear"

            
            };
        }
        
    }
}