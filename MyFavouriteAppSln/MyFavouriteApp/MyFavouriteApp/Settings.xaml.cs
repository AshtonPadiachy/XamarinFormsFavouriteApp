using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFavouriteApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();

           // var entry = new Entry { Placeholder = "Email", PlaceholderColor = Color.Gray };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUp());
        }
    }
}