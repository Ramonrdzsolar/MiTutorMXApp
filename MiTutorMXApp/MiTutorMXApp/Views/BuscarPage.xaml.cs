using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiTutorMXApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuscarPage : ContentPage
    {
        public BuscarPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await frame.ScaleTo(1.1, 100);

            await frame.ScaleTo(1, 100);
            await Navigation.PushAsync(new TutorPerfilPage());
        }
    }
}