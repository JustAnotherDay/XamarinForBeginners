using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinForBeginners.Models;

namespace XamarinForBeginners.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<Anime> Animes { get; set; }

        public MainPageViewModel()
        {

        }
    }
}
