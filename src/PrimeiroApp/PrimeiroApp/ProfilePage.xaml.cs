namespace PrimeiroApp;

public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();
    }

    private async void OnSaveProfileClicked(object sender, EventArgs e)
    {
        // Validação básica
        if (string.IsNullOrWhiteSpace(EntryName.Text))
        {
            LabelStatus.Text = "⚠️ Por favor, insira seu nome";
            LabelStatus.TextColor = Colors.Red;
            return;
        }

        if (string.IsNullOrWhiteSpace(EntryEmail.Text) || !EntryEmail.Text.Contains("@"))
        {
            LabelStatus.Text = "⚠️ Por favor, insira um e-mail válido";
            LabelStatus.TextColor = Colors.Red;
            return;
        }

        // Simular salvamento
        LabelStatus.Text = "✅ Perfil salvo com sucesso!";
        LabelStatus.TextColor = Colors.Green;

        await DisplayAlert("Sucesso",
            $"Perfil salvo!\n\nNome: {EntryName.Text}\nEmail: {EntryEmail.Text}\nTelefone: {EntryPhone.Text}",
            "OK");
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        EntryName.Text = "";
        EntryEmail.Text = "";
        EntryPhone.Text = "";
        EditorBio.Text = "";
        LabelStatus.Text = "Campos limpos";
        LabelStatus.TextColor = Colors.Gray;
    }
}
