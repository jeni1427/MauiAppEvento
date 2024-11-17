namespace MauiAppEvento.Confirmar;

public partial class PaginaDados : ContentPage
{
	public PaginaDados()
	{
		InitializeComponent();
	}

    private void Btn_confirmar_Clicked(object sender, EventArgs e)
    {
       DisplayAlert("Confirmação", "Evento confirmado com sucesso!", "OK");
        Navigation.PopAsync();
    }

    private void Btn_voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}