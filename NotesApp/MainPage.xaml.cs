namespace NotesApp
{
    public partial class MainPage : ContentPage
    {
        string nome = "";

        public MainPage()
        {
            InitializeComponent();
        }

        //metodo do botao
        private void OiButton_Clicked(object sender, EventArgs e)
        {
            //OiButton
            //NomeLabel
            //EntradaEntry
            //Digitar nome no EntradaEntry...
            //Clicar no botão OiButton...
            //Trocar conteúdo do NomeLabel
            nome = EntradaEntry.Text;
            NomeLabel.Text = $"Olá, {nome}!";
            //NomeLabel.Text = "Olá, " + nome + "!";
            EntradaEntry.IsReadOnly = true;
        }

    }

}
