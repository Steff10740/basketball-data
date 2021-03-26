using BasketBall_Data_Project.Constants;
using BasketBall_Data_Project.Models.SeasonModel;
using BasketBall_Data_Project.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;

namespace BasketBall_Data_Project.ViewModels
{
    public class SeasonViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.seasonTitle;

        private ISeasonApiService seasonApiService;
        public ObservableCollection<Datum> SeasonsData { get; set; }
        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;
        public ICommand GetSeason { get; }

        public SeasonViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            seasonApiService = new SeasonApiService();
            GetSeason = new DelegateCommand(GetSeasonAsync);
        }

        public async void GetSeasonAsync()
        {
            IsBusy = true;
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await AlertService.DisplayAlertAsync("Error", "No internet connection, try later.", "Ok");
            }
            else
            {
                var SeasonList = await seasonApiService.GetInfoAsync(Config.seasonURL);
                SeasonsData = SeasonList.Data;
            }
            IsBusy = false;
        }
    }
}
