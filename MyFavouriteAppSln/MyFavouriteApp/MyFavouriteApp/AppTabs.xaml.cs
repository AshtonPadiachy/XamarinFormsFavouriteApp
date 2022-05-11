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
    public partial class AppTabs : TabbedPage
    {
        public AppTabs()
        {
            InitializeComponent();

            Children.Add(new HomePage());
            Children.Add(new Search());
            Children.Add(new Favorites());
            Children.Add(new Downloads());
            Children.Add(new Settings());
        }
    }
}