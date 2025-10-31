namespace MauiAppHotel.Views;

public partial class ContrataçãoHospedagem : ContentPage
{
	public ContrataçãoHospedagem()
	{
		InitializeComponent();
	}
    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}