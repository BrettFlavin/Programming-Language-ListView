using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW4_List
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            list.ItemsSource = MainViewModel.LanguageList;      // bind LanguageList to ListView with name "list'
        }

        public void OnMore(object sender, EventArgs e)
        {
            var selectedItem = ((MenuItem)sender);
            var selectedLanguage = selectedItem.CommandParameter as Language;

            DisplayAlert("More", $"Here is more info on {selectedLanguage.Name}", "OK");
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var selectedItem = ((MenuItem)sender);
            var selectedLanguage = selectedItem.CommandParameter as Language;

            DisplayAlert("Delete", $"You wish to delete {selectedLanguage.Name}", "OK");
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}
