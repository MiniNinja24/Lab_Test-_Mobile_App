using Lab_Test__Mobile_App.View;

namespace Lab_Test__Mobile_App
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnFrame1Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Q1());
        }

        private async void OnFrame2Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Q2());
        }
        private async void OnFrame3Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Q3());
        }
    }

}
