using Arrival.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Arrival.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}