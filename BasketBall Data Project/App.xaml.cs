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
            await NavigationService.NavigateAsync(NavigationConst.Home);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CustomTabbedPage>(NavigationConst.Tabs);
            containerRegistry.RegisterForNavigation<NavigationPage>(NavigationConst.Navigate);

            containerRegistry.RegisterForNavigation<StandingPage, StandingViewModel>(NavigationConst.Standing);
            containerRegistry.RegisterForNavigation<LeaguePage, LeagueViewModel>(NavigationConst.League);
            containerRegistry.RegisterForNavigation<EventPage, EventViewModel>(NavigationConst.Event);
            containerRegistry.RegisterForNavigation<SeasonPage, SeasonViewModel>(NavigationConst.Season);
            containerRegistry.RegisterForNavigation<TeamPage, TeamViewModel>(NavigationConst.Team);

        }
    }
}
