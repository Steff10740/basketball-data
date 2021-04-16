using BasketBall_Data_Project.Constants;
using Prism.Navigation;
using BasketBall_Data_Project.Models;
using Prism.Services;
using BasketBall_Data_Project.Services;

namespace BasketBall_Data_Project.ViewModels
{
    public class LiveGameDetailsViewModel : BaseViewModel, INavigationAware
    {
        public override string Title { get; set; } = Config.LiveGamesTitle;
        public Datum LiveGameDetails { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public LiveGameDetailsViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IEventApiService eventApiService) : base(navigationService, pageDialogService)
        { }

        public void OnNavigatedFrom(INavigationParameters parameters) { }
        public void OnNavigatedTo(INavigationParameters parameters)
        {
            LiveGameDetails = parameters.GetValue<Datum>("details");
            Name = LiveGameDetails.Name;
        }
    }
}
