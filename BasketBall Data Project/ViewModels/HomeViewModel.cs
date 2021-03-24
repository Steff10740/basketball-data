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
    public class HomeViewModel : BaseViewModel, INavigatedAware
    {
        public override string Title { get; set; } = "Home";

        public string Name { get; set; }
        public string Phone { get; set; }

        public ICommand ShowDetailCommand { get; }

        public HomeViewModel(INavigationService navigationService, IPageDialogService alertService) : base(navigationService, alertService)
        {
            ShowDetailCommand = new Command(async () => await ExecuteDetail());
        }

        public async Task ExecuteDetail()
        {
            await AlertService.DisplayAlertAsync("Alert", "Navigate to Detail", "Ok");
            await NavigationService.NavigateAsync("Detail");
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if(parameters.GetNavigationMode() == NavigationMode.Back)
            {
                if (parameters.TryGetValue("Name", out string name))
                {
                    Name = name;
                }

                if (parameters.TryGetValue("Phone", out string phone))
                {
                    Phone = phone;
                }
            }
        }
    }
}
