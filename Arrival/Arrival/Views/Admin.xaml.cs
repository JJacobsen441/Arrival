using Arrival.Controllers;
using Arrival.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Arrival.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Admin : ContentPage
    {
        Controller con;
        public Admin()
        {
            InitializeComponent();

            con = new Controller();
        }

        public void OnSave1Clicked(object sender, EventArgs e)
        {
            try
            {
                DTOCitizen citizenItem1 = new DTOCitizen() { CPR = "260380-2503", FirstName = "Joakim", LastName = "Jacobsen" };
                DTOCitizen citizenItem2 = new DTOCitizen() { CPR = "260380-2504", FirstName = "Josephine", LastName = "Johansen" };
                DTOCitizen citizenItem3 = new DTOCitizen() { CPR = "260380-2505", FirstName = "Jakob", LastName = "Jensen" };

                con.SaveItem(citizenItem1);
                con.SaveItem(citizenItem2);
                con.SaveItem(citizenItem3);

                // Navigate backwards
                //await Navigation.PopAsync();
            }
            catch (Exception _e) 
            {
                ;
            }
        }

        public void OnShow1Clicked(object sender, EventArgs e)
        {
            try
            {
                List<DTOCitizen> list = con.GetItems();

                Label1.Text = list[0].FirstName + " " + list[0].LastName;
                Label2.Text = list[1].FirstName + " " + list[1].LastName;
                Label3.Text = list[2].FirstName + " " + list[2].LastName;

                // Navigate backwards
                //await Navigation.PopAsync();
            }
            catch (Exception _e) 
            {
                ;
            }
        }
    }
}