using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace NotesApp;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private void PerfilButton_Clicked(object sender, EventArgs e)
    {
        //Classe para relacionar o link e gerar a chamada de interface
        Uri link = new Uri("http://github.com/prof-isack");
        //Classe que executa a chamada de um aplicativo padr�o para a solicita��o,
        //nesse caso, o link gerado.
        Launcher.OpenAsync(link);
    }
}