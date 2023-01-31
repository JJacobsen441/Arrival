using Arrival._Statics;
using Arrival.Models;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Arrival.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            DTOWelcome dto = (Shell.Current as AppShell).welcome;

            if (dto.IsNull())
                return;

            Label1.Text = dto.Welcome;
            Label2.Text = dto.Message;

            Task.Factory.StartNew(async () =>
            {
                var time = DateTime.Now;
                var counter = 15;
                //transactionItem.RetryCount = 30;
                do
                {
                    await Task.Delay(1000);
                    counter--;

                    if(counter == 0)
                        await Shell.Current.GoToAsync("//CheckIn");

                } while (counter > 0);
            });
        }
    }
}