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
    public class LeagueDetailsViewModel : BaseViewModel, INavigatedAware
    {
        public override string Title { get; set; } = Config.DetailsTitle;
        public Datum LeagueDetails { get; set; }
        public string Name { get; set; }

        public LeagueDetailsViewModel(INavigationService navigationService, IPageDialogService pageDialogService, LeagueApiService leagueApiService) : base(navigationService, pageDialogService)
        {
            Name = LeagueDetails.Name;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }
        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.GetNavigationMode() == NavigationMode.New)
            {
                if (parameters.TryGetValue("Name", out Datum name))
                {
                    Name = name.ToString();
                }
            }
        }
    }
}
