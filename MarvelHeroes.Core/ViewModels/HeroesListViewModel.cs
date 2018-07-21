using MvvmCross.ViewModels;

namespace MarvelHeroes.Core.ViewModels
{
    public class HeroesListViewModel : MvxViewModel
    {
        private string _text;
        public string Text
        {
            get => _text;
            set => SetProperty(ref _text , value);
        }

        public HeroesListViewModel()
        {
            Text = "casa";
        }
    }
}
