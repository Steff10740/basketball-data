using BasketBall_Data_Project.Constants;
using BasketBall_Data_Project.Models.LeagueModel;
using BasketBall_Data_Project.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BasketBall_Data_Project.ViewModels
{
    public class LeagueViewModel : BaseViewModel
    {
        public override string Title { get; set; } = Config.LeagueTitle;
        public ObservableCollection<Datum> LeaguesData { get; set; }
        public bool IsBusy { get; set; }
        public bool IsDataVisible { get; set; }

        public ICommand ShowDetails { get; }

        //private ICommand SelectedItemCommand { get; }

        //private Datum _item;
        //public Datum SelectedItem
        //{
        //    get
        //    {
        //        return _item;
        //    }
        //    set
        //    {
        //        _item = value;

        //        if (_item != null)
        //        {

        //            SelectedItemCommand.Execute(_item);
        //        }
        //    }
        //}

        public ICommand ShowDetails { get; set; } /*=> new DelegateCommand<Datum>(async (leagueDetails) =>
        //{
        //    /*var navParameters = new NavigationParameters
        //        {
        //            {"details", leagueDetails}
        //        };*/
        //    await NavigationService.NavigateAsync("/Navigate/LeagueDetails");
        //});*/

        ILeagueApiService _leagueApiService;
        public INavigationService _navigationService { get; set; }

        public LeagueViewModel(INavigationService navigationService, IPageDialogService pageDialogService, LeagueApiService leagueApiService) : base(navigationService, pageDialogService)
        {
            _leagueApiService = leagueApiService;
            _navigationService = navigationService;

            //SelectedItemCommand = new Command<Datum>(OnItemSelected);
            GetLeaguesAsync();
            ShowDetails = new DelegateCommand<Datum>(async (leagueDetails) =>
            {
                /*var navParameters = new NavigationParameters
                {
                    {"details", leagueDetails}
                };*/
                await _navigationService.NavigateAsync("/Navigate/Tabs/Leagues/LeagueDetails");
            });
            
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
            var leagues = await _leagueApiService.GetInfoAsync();
            LeaguesData = leagues.Data;
            IsBusy = false;
            IsDataVisible = true;
        }

        private async void OnItemSelected(Datum leagueDetail)
        {
            var parameters = new NavigationParameters()
            {
                { "Name" , leagueDetail.Name}
            };
            //parameters.Add("Phone", Phone);
            await NavigationService.GoBackAsync(parameters);



            //var parameters = new NavigationParameters();
            //await NavigationService.NavigateAsync(NavigationConstants.LeagueDetails, parameters);
            //var navParameters = new NavigationParameters
            //{
            //    {"details", leagueDetails}
            //};
            //await NavigationService.NavigateAsync("/Navigate/League/LeagueDetails", navParameters);
            await AlertService.DisplayAlertAsync("League", leagueDetail.Name, "Ok");
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
