using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Lakeland_Church_App;

namespace Lakeland_Church_App
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnVideoPageButtonClicked(object sender, EventArgs e)
        {
            // Page appearance not animated
            await Navigation.PushAsync(new Videos(), false);
        }
    }
}
