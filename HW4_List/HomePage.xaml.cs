using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HW4_List
{
    public partial class HomePage : ContentPage
    {       
        public ObservableCollection<Language> DisplayList { get; set; } // a collection that will be used to display each programming langauge's info
        public int Display_Index { get; set; }                          // tracks items inserted into DisplayList when LanguageButton is clicked
        public int Model_Index { get; set; }                            // tracks items removed from DisplayList when Context Action "Delete" is clicked 
        
                
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
            // get the Language element behind the MenuItem
            var selectedItem = ((MenuItem)sender);
            var selectedLanguage = selectedItem.CommandParameter as Language;   
          
            // create a new detail page with the selected language
            await Navigation.PushAsync(new DetailPage(selectedLanguage));
        }
        
        // event is fired when user clicks "Delete" MenuItem
        private void OnDelete(object sender, EventArgs e)
        {
            // get the Language element behind the MenuItem
            var selectedItem = ((MenuItem)sender);
            var selectedLanguage = selectedItem.CommandParameter as Language;

            // remove the language element from DisplayList and update its index
            if (DisplayList.Count > 0)           
            {                
                DisplayList.Remove(selectedLanguage);
                --Display_Index;
            }
            else
            {
                DisplayAlert("Sorry!", "There are no items to delete!", "OK");
            }
        }

        // event is fired when user clicks on the "Language" button        
        private void LanguageButton_Clicked(object sender, EventArgs e)
        {
            // DisplayList is populated from MainViewModel's LanguageList
            // if we still have more Languages to add - add one each time button is clicked
            if (Model_Index < MainViewModel.LanguageList.Count)
            {               
                DisplayList.Insert(Display_Index, MainViewModel.LanguageList[Model_Index]);
                ++Display_Index;
                ++Model_Index;
            }

            // else we have added all Languages to DisplayList - give alert to user
            else
            {
                DisplayAlert("Sorry!", "That's all the languages for now!", "OK");
            }
           
        }

        // event is fired when user pulls down on list to refresh
        private void List_Refreshing(object sender, EventArgs e)
        {
            // clear the display list and reset both indexes
            DisplayList.Clear();
            Display_Index = 0;
            Model_Index = 0;

            // must set isRefreshing to false after event fires
            ((ListView)sender).IsRefreshing = false;
            DisplayAlert("Feeling Refreshed!", "Let's do it again!", "OK");
        }
    }
}
