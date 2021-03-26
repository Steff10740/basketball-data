using BasketBall_Data_Project.Models.SeasonModel;
using BasketBall_Data_Project.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using static BasketBall_Data_Project.Models.SeasonModel.SeasonInfo;

namespace BasketBall_Data_Project.ViewModels
{
    public class SeasonViewModel : BaseViewModel
    {
        
        ISeasonLAPIService seasonLAIService;


        public SeasonViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            seasonLAIService = new SeasonLAPIService();
            GetSeason = new Command(GetSeasonAsync);
        }

        public async void GetSeasonAsync()
        {
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await App.Current.MainPage.DisplayAlert("Aviso", "Conectese al internet", "OK");
                return;
            }
            IsDataVisible = false;
            IsBusy = true;
            var SeasonList = await seasonLAIService.GetSeasonInfoAsync();
            SeasonslData = SeasonList.Data;
            IsBusy = false;
            IsDataVisible = true;
        }
        
        public override string Title { get; set; } = "Season";
        public ObservableCollection<Datum> SeasonslData { get; set; }
        public bool IsBusy { get; set; }
        public bool IsDataVisible { get; set; }
        public ICommand GetSeason { get; }
    }
        
}
