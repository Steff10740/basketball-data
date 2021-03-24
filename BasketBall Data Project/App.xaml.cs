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
            //await NavigationService.NavigateAsync("Home");
            await NavigationService.NavigateAsync("/Navigate/Tabs");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CustomTabbedPage>("Tabs");
            containerRegistry.RegisterForNavigation<NavigationPage>("Navigate");
            containerRegistry.RegisterForNavigation<HomePage,HomeViewModel>("Home");
            containerRegistry.RegisterForNavigation<DetailPage,DetailViewModel>("Detail");
        }
    }
}
