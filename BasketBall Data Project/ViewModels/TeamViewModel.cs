using BasketBall_Data_Project.Constants;
using BasketBall_Data_Project.Models.TeamModel;
using BasketBall_Data_Project.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;

namespace BasketBall_Data_Project.ViewModels
{
    public class TeamViewModel : BaseViewModel
    {        
        public override string Title { get; set; } = Config.TeamTitle;

        public ObservableCollection<Datum> Teams { get; set; }
        public ICommand GetTeams { get; }
        private ITeamApiService _teamApiService;
        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;

        public TeamViewModel(INavigationService navigationService, IPageDialogService pageDialogService, ITeamApiService teamApiService) : base(navigationService, pageDialogService)
        {
            _teamApiService = teamApiService;
            LoadTeams();
        }

        private async void LoadTeams()
        {
            IsBusy = true;
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await AlertService.DisplayAlertAsync("Error", "No internet connection, try later.","Ok");
            }
            else
            {
                var teams = await _teamApiService.GetInfoAsync();
                Teams = teams.Data;
            }
            IsBusy = false;
        }

        //private async void OnPlaceSelected(Team team)
        //{
        //    await NavigationService.NavigateAsync(Config.);
        //}
    }
}
