namespace MauiAppHotel.Views;

public partial class ContrataçãoHospedagem : ContentPage
{
    App PropriedadesApp;

	public ContrataçãoHospedagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
    }

   

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }

   

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());

        } catch (Exception ex)

        {
            DisplayAlert("ops", ex.Message, "OK");
        }
    }
}