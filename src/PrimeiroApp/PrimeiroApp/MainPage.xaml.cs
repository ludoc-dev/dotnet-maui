using System.Windows.Input;

namespace PrimeiroApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnViewScreensClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Telas Disponíveis",
            "Este aplicativo possui 3 telas principais:\n\n• Início - Menu e informações\n• Perfil - Dados do usuário\n• Configurações - Preferências",
            "OK");
    }

    private async void OnProfileClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///ProfilePage");
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///SettingsPage");
    }

    private async void OnAboutClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Sobre",
            "Primeiro App .NET MAUI\n\n" +
            "Desenvolvido para a disciplina de\n" +
            "Programação Para Dispositivos Móveis\n\n" +
            "Professor: Rafael Soares de Almeida\n" +
            "1º Semestre 2026\n\n" +
            "Versão: 1.0.0",
            "OK");
    }
}
