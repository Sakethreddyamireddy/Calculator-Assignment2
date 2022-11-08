using Microsoft.Maui.Controls.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator;

public partial class Question1 : ContentPage
{
	public Question1()
	{
		InitializeComponent();
	}
	public bool _showText = false;

    async void AnsClicked(object sender, EventArgs e)
	{
		_showText = true;
		bool ans = await  DisplayAlert("Right Answer!", "Would you like to answer next question", "Yes", "No");
		if(ans)
		{
            App.Current.MainPage = new NavigationPage(new Question2());
        }
		else
		{
            App.Current.MainPage = new NavigationPage(new Question1());
        }
	}
	async void WrongClicked(object sender, EventArgs e)
	{
		_showText = false;
		bool wrng = await DisplayAlert("Wrong Answer!", " ", "Next", "Try Again");

    }
	void NextClicked(object sender, EventArgs e)
	{
        App.Current.MainPage = new NavigationPage(new Question2());
    }
}