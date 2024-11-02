namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var windows = base.CreateWindow(activationState);

            windows.Width = 400;
            windows.Height = 600;

            return windows;
           
        }
    }
}
