namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new Sobre());

        }
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "ok");
		}
    }
}