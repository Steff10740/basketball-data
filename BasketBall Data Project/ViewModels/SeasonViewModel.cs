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
        public override string Title { get; set; } = Config.SeasonTitle;

        private ISeasonApiService _seasonApiService;
        public ObservableCollection<Data> SeasonsData { get; set; }
        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;
        public ICommand GetSeason { get; }

        public SeasonViewModel(INavigationService navigationService, IPageDialogService pageDialogService, ISeasonApiService seasonApiService) : base(navigationService, pageDialogService)
        {
            _seasonApiService = seasonApiService;
            GetSeasonAsync();
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
                var SeasonList = await _seasonApiService.GetInfoAsync();
                SeasonsData = SeasonList.Data;
            }
            IsBusy = false;
        }
    }
}
