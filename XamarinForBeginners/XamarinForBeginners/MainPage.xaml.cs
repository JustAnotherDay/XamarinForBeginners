using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinForBeginners.Models;
using XamarinForBeginners.ViewModel;

namespace XamarinForBeginners
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public IList<Anime> Animes { get; private set; }
        MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();


            BindingContext = viewModel = new MainPageViewModel();

            Animes = new List<Anime>();
            Animes.Add(new Anime
            {
                Name = "Hunter X Hunter",
                Description = "loremlorem loremloremloremloremloremlorem",
                ImageUrl = @"hunterx.jpg"
            });

            Animes.Add(new Anime
            {
                Name = "Naruto",
                Description = "loremlorem loremloremloremloremloremlorem",
                ImageUrl = @"naruto.jpg"
            });

            Animes.Add(new Anime
            {
                Name = "One Piece",
                Description = "loremlorem loremloremloremloremloremlorem",
                ImageUrl = @"onepiece.jpg"
            });

            Animes.Add(new Anime
            {
                Name = "One Punch",
                Description = "loremlorem loremloremloremloremloremlorem",
                ImageUrl = @"onepunch.jpg"
            });
        }


        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            animeListView.ItemsSource = Animes;
        }
    }
}
