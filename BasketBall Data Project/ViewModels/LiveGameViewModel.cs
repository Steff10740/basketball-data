using BasketBall_Data_Project.Constants;
using BasketBall_Data_Project.Models;
using BasketBall_Data_Project.Models.Event;
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
    public class LiveGameViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.LiveGamesTitle;

        public ObservableCollection<Datum> Events { get; set; }
        private IEventApiService _eventApiService;
        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;
        public ICommand ShowDetails { get; }
        public INavigationService _navigationService { get; set; }

        public LiveGameViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IEventApiService eventApiService) : base(navigationService, pageDialogService)
        {
            _eventApiService = eventApiService;
            _navigationService = navigationService;
            LoadLiveGames();


            ShowDetails = new DelegateCommand<Datum>(async (gameDetails) =>
            {
                var navParameters = new NavigationParameters
                {
                    { ParameterConstants.Event, gameDetails}
                };
                await _navigationService.NavigateAsync(NavigationConstants.LiveGameDetails, navParameters);
            });

            //GetGame();
        }

        private async void LoadLiveGames()
        {
            IsBusy = true;
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await AlertService.DisplayAlertAsync(AlertDialogConstants.Error, AlertDialogConstants.NoInternet, AlertDialogConstants.Ok);
            }
            else
            {
                var events = await _eventApiService.GetInfoAsync();
                Events = events.Data;
            }
            IsBusy = false;
        }


        //private void GetGame()
        //{
        //    Events = new ObservableCollection<Datum>();
        //    var events = new Datum
        //    {
        //        AwayTeam = new AwayTeam(),
        //        HomeTeam = new HomeTeam(),
        //        AwayScore = new AwayScore(),
        //        HomeScore = new HomeScore()
        //    };

        //    events.AwayTeam.Logo = "http://tipsscore.com/storage/team-logo/at/la/atlanta-hawks.png";
        //    events.HomeTeam.Logo = "http://tipsscore.com/storage/team-logo/da/ll/dallas-mavericks.png";
        //    events.AwayScore.Current = 103;
        //    events.HomeScore.Current = 114;
        //    events.HomeScore.Point = "114 - 103";

        //    Events.Add(events);
        //}
    }
}
