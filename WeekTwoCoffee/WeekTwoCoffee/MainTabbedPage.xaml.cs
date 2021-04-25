using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeekTwoCoffee
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
        }

        private async void drinksBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DrinksPage());
        }

        private async void breakfastBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BreakfastPage());
        }

        private async void brunchBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrunchPage());
        }

        private async void lunchBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LunchPage());
        }
    }
}