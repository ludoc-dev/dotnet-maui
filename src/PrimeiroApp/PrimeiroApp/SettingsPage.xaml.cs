namespace PrimeiroApp;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }

    private async void OnTermsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Termos de Uso",
            "Ao usar este aplicativo, você concorda com os termos de uso da disciplina de Programação Para Dispositivos Móveis.\n\n" +
            "Este é um aplicativo educacional desenvolvido para fins de aprendizado.",
            "Entendi");
    }

    private async void OnPrivacyClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Política de Privacidade",
            "Seus dados são armazenados localmente no dispositivo.\n\n" +
            "Nenhuma informação pessoal é coletada ou enviada para servidores externos.\n\n" +
            "Este app respeita sua privacidade.",
            "Entendi");
    }

    private async void OnResetClicked(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Restaurar",
            "Deseja restaurar todas as configurações para o padrão?",
            "Sim", "Não");

        if (answer)
        {
            SwitchNotifications.IsToggled = true;
            SwitchDarkMode.IsToggled = false;
            SwitchSound.IsToggled = true;
            SwitchVibration.IsToggled = true;

            LabelSettingsStatus.Text = "✅ Configurações restauradas";
            LabelSettingsStatus.TextColor = Colors.Green;
        }
    }
}
