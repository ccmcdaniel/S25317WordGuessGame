namespace S25317WordGuessGame.Project.Views;

public partial class MainMenuPage : ContentPage
{
	public MainMenuPage()
	{
		InitializeComponent();
	}

    private void ClickNewGameButton(object sender, EventArgs e)
    {
		App.Current.Windows[0].Page = new Project.Views.GamePage();
    }
}