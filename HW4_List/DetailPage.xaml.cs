using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HW4_List
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        
        public DetailPage(Language theLanguage)
        {
            InitializeComponent();            
            BindingContext = theLanguage;
        }

        // event is fired when user clicks on the "Example" button 
        async void ExampleButton_Clicked(object sender, EventArgs e) 
        {
           // create a new ExamplePage with an example from the language
           await Navigation.PushAsync(new ExamplePage((Language)this.BindingContext));
        }
    }
}