using MiTutorMXApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MiTutorMXApp.Views
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