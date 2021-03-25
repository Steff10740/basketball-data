using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketBall_Data_Project.ViewModels
{
    public class StandingViewModel : BaseViewModel
    {
        public override string Title { get; set; } = "Standings";

        public StandingViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {

        }
    }
}
