using Arrival.Models;
using Arrival.ViewModels;
using Arrival.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Arrival
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public DTOWelcome welcome;
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        public AppShell(DTOWelcome wm)
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));

            welcome = wm;
        }
    }
}
