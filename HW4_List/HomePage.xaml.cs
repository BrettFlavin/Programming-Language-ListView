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
      
        // ObervableCollection that will be used to display each programming langauge's info
        public ObservableCollection<Language> DisplayList { get; set; }

        // index to retreive elements from LanguageList and 
        // insert into DisplayList when LanguageButton is clicked
        public int index { get; set; }

        public HomePage()
        {
            InitializeComponent();
            
            // initialize a new empty Collection and bind it to our ListView's ItemSource
            DisplayList = new ObservableCollection<Language>();                                           
            list.ItemsSource = DisplayList;           
        }

        // event is fired when user clicks "More" MenuItem
        async void OnMore(object sender, EventArgs e)
        {
            var selectedItem = ((MenuItem)sender);
            var selectedLanguage = selectedItem.CommandParameter as Language;   
            
            // create a new detail page with the selected language
            await Navigation.PushAsync(new DetailPage(selectedLanguage));
        }

        /************* TO DO ***************
        ************************************/
        // event is fired when user clicks "Favorite" MenuItem
        public void OnFavorite(object sender, EventArgs e)
        {
            var selectedItem = ((MenuItem)sender);
            var selectedLanguage = selectedItem.CommandParameter as Language;
            DisplayAlert("Favorite", $"Adding {selectedLanguage.Name} to favorites", "OK");
        }

        // event is fired when user clicks on the "Language" button        
        private void LanguageButton_Clicked(object sender, EventArgs e)
        {
            // the DisplayList is populated from the MainViewModel's LanguageList
            // if we still have more languages to add - add one each time button is clicked
            if (index < MainViewModel.LanguageList.Count)
            {               
                DisplayList.Insert(index, MainViewModel.LanguageList[index]);
                ++index;
            }

            // else we have added all languages to DisplayList - give alert to user
            else
            {
                DisplayAlert("Sorry!", "That's all the languages for now!", "OK");
            }
           
        }

        // event is fired when user pulls down on list to refresh
        private void List_Refreshing(object sender, EventArgs e)
        {
            // clear the display list and set index to 0
            DisplayList.Clear();
            index = 0;
            // must set isRefreshing to false after event fires
            ((ListView)sender).IsRefreshing = false;
            DisplayAlert("So Refreshed!", "Let's do it again!", "OK");
        }
    }
}
