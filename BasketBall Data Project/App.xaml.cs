using BasketBall_Data_Project.Constants;
using BasketBall_Data_Project.Services;
using BasketBall_Data_Project.ViewModels;
using BasketBall_Data_Project.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasketBall_Data_Project
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer) { }
        
        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("/Navigate/Tabs");//{NavigationConstants.Navigate}/{NavigationConstants.Tabs}
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ITeamApiService, TeamApiService>();
            containerRegistry.Register<ISeasonApiService, SeasonApiService>();
            containerRegistry.Register<ILeagueApiService, LeagueApiService>();
            containerRegistry.Register<ISerializerService, SerializerService>();
            containerRegistry.Register<IEventApiService, EventApiService>();

            containerRegistry.RegisterForNavigation<CustomTabbedPage>(NavigationConstants.Tabs);
            containerRegistry.RegisterForNavigation<NavigationPage>(NavigationConstants.Navigate);
            containerRegistry.RegisterForNavigation<LeaguePage>("Leagues");
            containerRegistry.RegisterForNavigation<LeagueDetailsPage>("LeagueDetails");

            //containerRegistry.RegisterForNavigation<StandingPage, StandingViewModel>(NavigationConstants.Standing);
            containerRegistry.RegisterForNavigation<LeaguePage, LeagueViewModel>("Leagues");
            containerRegistry.RegisterForNavigation<EventPage, EventViewModel>(NavigationConstants.Event);
            containerRegistry.RegisterForNavigation<SeasonPage, SeasonViewModel>(NavigationConstants.Season);
            containerRegistry.RegisterForNavigation<TeamPage, TeamViewModel>(NavigationConstants.Team);
            containerRegistry.RegisterForNavigation<LeagueDetailsPage, LeagueDetailsViewModel>("LeagueDetails");

        }
    }
}
