using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketBall_Data_Project.ViewModels
{
    public class EventViewModel : BaseViewModel
    {
        public override string Title { get; set; } = "Events";

        public EventViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {

        }
    }
}
