using ProtogenControl.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProtogenControl.Views
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