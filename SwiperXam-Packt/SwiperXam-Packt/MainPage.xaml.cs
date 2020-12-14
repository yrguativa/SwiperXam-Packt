using SwiperXam_Packt.Controls;
using Xamarin.Forms;

namespace SwiperXam_Packt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MainGrid.Children.Add(new SwiperControl());

        }
    }
}
