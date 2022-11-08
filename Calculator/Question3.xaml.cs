

namespace Calculator;

public partial class Question3 : ContentPage
{
    public Question3()
    {
        InitializeComponent();
    }
    public bool _showText = false;

    async void AnsClicked(object sender, EventArgs e)
    {
        _showText = true;
        bool ans = await DisplayAlert("Right Answer!", "Would you like to answer next question", "Yes", "No");
        if (ans)
        {
            App.Current.MainPage = new NavigationPage(new Question4());
        }
        else
        {
            App.Current.MainPage = new NavigationPage(new Question3());
        }
    }
    async void WrongClicked(object sender, EventArgs e)
    {
        _showText = false;
        bool wrng = await DisplayAlert("Wrong Answer!", " ", "Next", "Try Again");
        if (wrng)
        {
            App.Current.MainPage = new NavigationPage(new Question4());
        }
        else
        {
            App.Current.MainPage = new NavigationPage(new Question3());
        }

    }
    void NextClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new Question4());
    }
}