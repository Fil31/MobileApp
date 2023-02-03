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
    public partial class EntryPage : ContentPage
    {
        Editor ed;
        public EntryPage()
        {
            ed= new Editor
            {
                Placeholder="Sisesta siia tekst",
                BackgroundColor=Color.MidnightBlue,
                TextColor=Color.White
            };
            Button Start_btn = new Button
            {
                Text = "Tagasi",
                TextColor = Color.Turquoise,
                BackgroundColor = Color.DarkRed
            };
            StackLayout st= new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { ed, Start_btn },
                BackgroundColor = Color.Orange
            };
            Content = st;
            Start_btn.Clicked += Start_btn_clicked;
        }
        private async void Start_btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StartPage());
        }
    }
}