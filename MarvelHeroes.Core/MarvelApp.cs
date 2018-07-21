using MarvelHeroes.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace MarvelHeroes.Core
{
    public class MarvelApp : MvxApplication
    {

        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HeroesListViewModel>();
        }
    }
}
