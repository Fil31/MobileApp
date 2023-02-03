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
                Text = "Ava leht",
                TextColor = Color.Turquoise,
                BackgroundColor = Color.DarkRed
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { Entry_btn },
                BackgroundColor = Color.Gold
            };
            Content= st;
            Entry_btn.Clicked += Entry_btn_clicked;
        }
        private async void Entry_btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryPage());
        }
    }
}