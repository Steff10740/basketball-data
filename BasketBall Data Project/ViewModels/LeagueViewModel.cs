using BasketBall_Data_Project.Models.LeagueModel;
using BasketBall_Data_Project.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BasketBall_Data_Project.ViewModels
{
    public class LeagueViewModel : BaseViewModel
    {
        public override string Title { get; set; } = "Leagues";
        public ObservableCollection<Datum> LeaguesData { get; set; }
        public bool IsBusy { get; set; }
        public bool IsDataVisible { get; set; }
        public ICommand GetLeagues { get; }
        ILeagueApiService leagueApiService;
        public LeagueViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            leagueApiService = new LeagueApiService();
            GetLeagues = new Command(GetLeaguesAsync);
        }
        private async void GetLeaguesAsync()
        {
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await App.Current.MainPage.DisplayAlert("Error", "No internet access.", "OK");
                return;
            }
            IsDataVisible = false;
            IsBusy = true;
            var leagues = await leagueApiService.GetLeaguesAsync();
            LeaguesData = leagues.Data;
            IsBusy = false;
            IsDataVisible = true;
        }
    }
}
