using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lakeland_Church_App.Models;

namespace Lakeland_Church_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Video : ContentPage
    {
        VideoItem model;
        public Video(String name)
        {
            
            InitializeComponent();
            this.model = new VideoItem();
            this.model.Name = name;
            BindingContext = this.model;
            //Label2.Text = this.videoName;



        }
    }
}