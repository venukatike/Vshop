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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            List<Image> images = new List<Image>()
            {
                new Image(){ Title ="image1",Url="slide1"},
                new Image(){ Title ="image2",Url="slide2"},
                new Image(){ Title ="image3",Url="slide3"}
            };

            carousel.ItemsSource=images;


            coll.ItemsSource = product;

           
        }

        List<Products> product = new List<Products>()
            {
                new Products(){img="Iphone7s.png",name="Apple iPhone 7S 16GB Gold",description="d", price="Rs.40,000" ,buy="Buy"},
                new Products(){img="iQOOZ6.png",name="iQOO vivo Z6 5G",description="iQOO vivo Z6 5G (Chromatic Blue, 4GB RAM, 128GB Storage) | Snapdragon 695-6nm Processor | 120Hz FHD+ Display | 5000mAh Battery | Travel Adapter to be Purchased Separately", price="Rs.40,000" ,buy="Buy"},
                new Products(){img = "JioPhone.png", name="Jio Phone ",description="sad", price="Rs.40,000" ,buy="Buy"},
                new Products(){img = "OppoF9.png", name="OPPO F9",description="OPPO F9 (Mystery Black, 6GB RAM, 128GB Storage) with No Cost EMI/Additional Exchange Offers", price="Rs.40,000" ,buy="Buy"},
                new Products(){img = "Poco.png", name="POCO C3",description="POCO C31 (Royal Blue, 64 GB) (4 GB RAM)", price="Rs.40,000" ,buy="Buy"},
                new Products(){img = "Iphone7s.png", name="Iphone 7s",description="sad", price="Rs.40,000" ,buy="Buy"},
        };

        public void s1(object sender, TextChangedEventArgs e)
            {
                var SearchResult = product.Where(c => c.name.ToLower().Contains(search1.Text.ToLower()));
                coll.ItemsSource = SearchResult;
            }
       
    }
}