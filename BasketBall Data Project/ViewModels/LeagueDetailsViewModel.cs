using System;
using System.Collections.Generic;
using System.Text;
using BasketBall_Data_Project.Constants;
using BasketBall_Data_Project.Models.LeagueModel;
using BasketBall_Data_Project.Services;
using Prism.Navigation;
using Prism.Services;

namespace BasketBall_Data_Project.ViewModels
{
    public class LeagueDetailsViewModel : BaseViewModel, INavigationAware
    {
        public override string Title { get; set; } = Config.DetailsTitle;
        public Datum LeagueDetails { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public LeagueDetailsViewModel(INavigationService navigationService, IPageDialogService pageDialogService, LeagueApiService leagueApiService) : base(navigationService, pageDialogService)
        {
            //string name = LeagueDetails.Name;
            //Name = name; //LeagueDetails.Name;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }
        public void OnNavigatedTo(INavigationParameters parameters)
        {
            LeagueDetails = parameters.GetValue<Datum>(ParameterConstants.League);
            Name = LeagueDetails.Name;
            Logo = LeagueDetails.Logo;
        }
    }
}
