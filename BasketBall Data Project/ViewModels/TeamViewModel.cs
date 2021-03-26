using BasketBall_Data_Project.Models.TeamModel;
using BasketBall_Data_Project.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;

namespace BasketBall_Data_Project.ViewModels
{
    public class TeamViewModel : BaseViewModel
    {        
        public override string Title { get; set; } = Config.teamTitle;

        public ObservableCollection<Datum> Teams { get; set; }
        public ICommand GetTeams { get; }
        private ITeamApiService teamApiService;
        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;

        public TeamViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            teamApiService = new TeamApiService();
            GetTeams = new DelegateCommand(LoadTeams);
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
                var teams = await teamApiService.GetInfoAsync(Config.teamURL);
                Teams = teams.Data;
            }
            IsBusy = false;
        }
    }
}
