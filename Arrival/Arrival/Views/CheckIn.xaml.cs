using Arrival._Statics;
using Arrival.Controllers;
using Arrival.Models;
using Arrival.ViewModels;
using System;
using System.ComponentModel;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Arrival.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckIn : ContentPage
    {
        string YourPropertyName;

        Controller con;
        public CheckIn()
        {
            InitializeComponent();

            con = new Controller();
            BindingContext = new CheckInViewModel();
            Entry1.TextChanged += Entry1TextChanged;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Label1.Text = "Velkommen";
            Entry1.BindingContext = new { MyEntry1 = "" };            
        }

        async void OnButton1Clicked(object sender, EventArgs args)
        {
            try
            {
                string cpr = Entry1.Text;

                if (cpr.IsNullOrEmpty())
                    return;

                if (!CheckHelper.IsCPR(cpr))
                    return;
                
                DTOWelcome wm = con.GetByCPR(cpr);
                
                (Shell.Current as AppShell).welcome = wm;
                await Shell.Current.GoToAsync("//Welcome");
            }
            catch (Exception _e)
            {
                ;//normally I would redirect to an error webpage
            }

        }

        public void Entry1TextChanged(object sender, TextChangedEventArgs args)
        {
            try
            {
                if (args.NewTextValue == args.OldTextValue)
                    return;
                
                string cpr = Entry1.Text;
                string cpr_old = args.OldTextValue;

                if (cpr.IsNullOrEmpty())
                    return;

                if(!CheckHelper.CheckDash(cpr))
                {
                    string _s = cpr_old;
                    Entry1.BindingContext = new { MyEntry1 = _s };
                    return;
                }
                else if (CheckHelper.FirstPart(cpr) && CheckHelper.SecondPart(cpr) && cpr.Count() < 11)
                {
                    if (!CheckHelper.IsDash(cpr_old) && CheckHelper.NeedsDash(cpr))
                        cpr += "-";

                    //Entry1.Text = cpr;
                    Entry1.BindingContext = new { MyEntry1 = cpr };
                    return;
                }
                else
                {
                    //Entry1.Text = CheckHelper.RemoveCharacters(Entry1.Text);
                    //Entry1.Text = Entry1.Text.Length > 11 ? Entry1.Text.Substring(0, 11) : Entry1.Text;

                    string _s = CheckHelper.RemoveCharacters(Entry1.Text);
                    Entry1.BindingContext = new { MyEntry1 = _s };

                    if (Entry1.Text.Length > 11)
                        Entry1.BindingContext = new { MyEntry1 = Entry1.Text.Substring(0, 11) };
                    return;
                }
            }
            catch (Exception _e)
            {
                ;//normally I would redirect to an error webpage
            }
        }
    }
}