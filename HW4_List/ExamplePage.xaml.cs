using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HW4_List
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExamplePage : ContentPage
    {
        public ExamplePage(Language theLanguage)
        {
            InitializeComponent();
            BindingContext = theLanguage;
        }

        // event is fired when user clicks "Home" Button
        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            // go back to HomePage
            await Navigation.PopToRootAsync();
        }
    }
}