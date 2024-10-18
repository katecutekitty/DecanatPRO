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

namespace BusinessLogic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleConfigModuleFlyout : ContentPage
    {
        public ListView ListView;

        public SimpleConfigModuleFlyout()
        {
            InitializeComponent();

            BindingContext = new SimpleConfigModuleFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class SimpleConfigModuleFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<SimpleConfigModuleFlyoutMenuItem> MenuItems { get; set; }

            public SimpleConfigModuleFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<SimpleConfigModuleFlyoutMenuItem>(new[]
                {
                    new SimpleConfigModuleFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new SimpleConfigModuleFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new SimpleConfigModuleFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new SimpleConfigModuleFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new SimpleConfigModuleFlyoutMenuItem { Id = 4, Title = "Page 5" },
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