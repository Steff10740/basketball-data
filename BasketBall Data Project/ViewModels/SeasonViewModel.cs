using BasketBall_Data_Project.Models.SeasonModel;
using BasketBall_Data_Project.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using static BasketBall_Data_Project.Models.SeasonModel.SeasonList;

namespace BasketBall_Data_Project.ViewModels
{
    public class SeasonViewModel : BaseViewModel
    {
        ISeasonLAPIService seasonLAIService;
        public override string Title { get; set; } = "Season";
        public ObservableCollection<Datum> SeasonsData { get; set; }
        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;
        public ICommand GetSeason { get; }

        public SeasonViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            seasonLAIService = new SeasonLAPIService();
            GetSeason = new Command(GetSeasonAsync);
        }

        public async void GetSeasonAsync()
        {
            IsBusy = true;
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await AlertService.DisplayAlertAsync("Error", "No internet connection, try later.", "Ok");
            }
            else
            {
                var SeasonList = await seasonLAIService.GetSeasonInfoAsync();
                SeasonsData = SeasonList.Data;
            }
            IsBusy = false;
        }
    }
}
