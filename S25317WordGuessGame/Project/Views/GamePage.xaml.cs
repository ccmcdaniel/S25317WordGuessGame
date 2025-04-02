namespace S25317WordGuessGame.Project.Views;

public partial class GamePage : ContentPage
{
	List<Button> letterButtons1 = new List<Button>();
	List<Button> letterButtons2 = new List<Button>();
	
	public GamePage()
	{
		InitializeComponent();

		

		string letters1 = "ABCDEFGHIJKLM";
		string letters2 = "NOPQRSTUVWXYZ";

		SetupLetterButtons(letters1, ref letterButtons1, layoutAlphabetButtons1);
		SetupLetterButtons(letters2, ref letterButtons2, layoutAlphabetButtons2);

	}

	void SetupLetterButtons(string letters, ref List<Button> buttons, HorizontalStackLayout view)
	{
		view.Clear();

        for (int i = 0; i < letters.Length; i++)
        {
            Button button = MakeLetterButton(letters[i]);

            Border bdr = new();
            bdr.Style = (Style)Application.Current.Resources["styleLetterButtonBorder"];

            buttons.Add(button);
            bdr.Content = button;

            view.Add(bdr);
        }
    }


	private Button MakeLetterButton(char text)
	{
		Button btn = new();
		btn.Style = (Style)Application.Current.Resources["styleLetterButton"];
		btn.Text = text.ToString();
		btn.Clicked += LetterButtonClicked;

		return btn;
    }

    private void LetterButtonClicked(object sender, EventArgs e)
    {
		Button b = (Button)sender;

		//Set the button's border to greyed out.
        Border bdr = (b.Parent as Border);
		bdr.Style = (Style)Application.Current.Resources["styleLetterButtonBorderDisabled"];


        DisplayAlert("Clicked Letter", $"You clicked {b.Text}", "Ok", "Cancel");

		b.IsEnabled = false;
    }
}