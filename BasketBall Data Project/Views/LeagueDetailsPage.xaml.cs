using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasketBall_Data_Project.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeagueDetailsPage : ContentPage
    {
        public LeagueDetailsPage()
        {
            InitializeComponent();

            //LabelName.Text = name;
        }
    }
}