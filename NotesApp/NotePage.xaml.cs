using Microsoft.Maui.Controls;

namespace NotesApp;

public partial class NotePage : ContentPage
{
    string fileName = Path.Combine(FileSystem.AppDataDirectory, "arquivo.txt");
    public NotePage()
    {
        InitializeComponent();
        try
        {
            TextoEditor.Text = File.ReadAllText(fileName);
        }
        catch
        {
            TextoEditor.Text = "Arquivo não existia!");

        }

    }

    private void SalvarButton_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(fileName, TextoEditor.Text);
        DisplayAlert("OK", "Arquivo salvo em:\n" + FileSystem.AppDataDirectory, "Valeu!");
    }

    private void DeletarButton_Clicked(object sender, EventArgs e)
    {
        File.Delete(fileName);
        DisplayAlert("Deletado", $"O arquivo \n" +
            $"{fileName}\n" +
            $"foi deletado com sucesso", "OK");
    }
}
