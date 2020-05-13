using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lakeland_Church_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Videos : ContentPage
    {
        public Videos()
        {
            InitializeComponent();
        }
        async void OnBackPageButtonClicked(object sender, EventArgs e)
        {
            // Page appearance not animated
            await Navigation.PopAsync(false);
        }
        async void OnVideoItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new Video(e.Item.ToString()), false);
        }
    }
}