using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vshop.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountFlyout : ContentPage
    {
        public ListView ListView;
        public AccountFlyout()
        {
            InitializeComponent();
            BindingContext = new FlyoutPage1FlyoutViewModel();
            ListView = MenuItemsListView;
        }
        private class FlyoutPage1FlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FlyoutPage1FlyoutMenuItem> MenuItems { get; set; }

            public FlyoutPage1FlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutPage1FlyoutMenuItem>(new[]
                {
                    new FlyoutPage1FlyoutMenuItem { Id = 0, Title = "Personal" ,TargetType=typeof(AccountPersonal)},
                    new FlyoutPage1FlyoutMenuItem { Id = 1, Title = "Orders", TargetType=typeof(AccountOrders)},
                    new FlyoutPage1FlyoutMenuItem { Id = 2, Title = "Privacy Policy" ,TargetType=typeof(AccountPrivacy)},
                    new FlyoutPage1FlyoutMenuItem { Id = 3, Title = "Contact us" ,TargetType=typeof(AccountContactUs)},
                    new FlyoutPage1FlyoutMenuItem { Id = 4, Title = "About",TargetType=typeof(AccountAbout)},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}