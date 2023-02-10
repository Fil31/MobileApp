using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            //initializeComponent();
            Button Entry_btn = new Button
            {
                Text = "Open main page",
                TextColor = Color.Turquoise,
                BackgroundColor = Color.DarkRed
            };
            Button Timer_btn = new Button
            {
                Text = "Open timer page",
                TextColor = Color.Turquoise,
                BackgroundColor = Color.DarkRed
            };
            Button BoxView_btn = new Button
            {
                Text = "Open boxview page",
                TextColor = Color.Turquoise,
                BackgroundColor = Color.DarkRed
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { Entry_btn, Timer_btn, BoxView_btn},
                BackgroundColor = Color.Gold
            };
            Content= st;
            Entry_btn.Clicked += Entry_btn_clicked;
            Timer_btn.Clicked += Timer_btn_clicked;
            BoxView_btn.Clicked += BoxView_btn_clicked;
        }
        private async void Entry_btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryPage());
        }
        private async void BoxView_btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxViewPage());
        }
        private async void Timer_btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer_Page());
        }
    }
}