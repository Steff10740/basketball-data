using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BasketBall_Data_Project.ViewModels
{
    public class DetailViewModel : BaseViewModel, IInitialize
    {
        public override string Title { get; set; } = "Detail";
        public string Name { get; set; }
        public string Phone { get; set; }

        public ICommand ShowDetailCommand { get; }

        public ICommand UpdateInformationCommand { get; }

        public DetailViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            ShowDetailCommand = new Command(async () => await ExecuteDetail());
            UpdateInformationCommand = new Command(async () => await ExecuteUpdateInformation());
        }

        private Task ExecuteUpdateInformation()
        {
            var parameters = new NavigationParameters()
            {
                { "Name" , Name }               
            };
            parameters.Add("Phone", Phone);
            return NavigationService.GoBackAsync(parameters);
        }

        public Task ExecuteDetail()
        {
            return NavigationService.NavigateAsync("DetailPage");
        }

        public void Initialize(INavigationParameters parameters)
        {
            if(parameters.TryGetValue("Title", out string title))
            {
                Title = title;
            }
        }
    }
}
