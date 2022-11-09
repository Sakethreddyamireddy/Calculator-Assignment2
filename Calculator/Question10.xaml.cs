
namespace Calculator;

public partial class Question10 : ContentPage
{
    public Question10()
    {
        InitializeComponent();
    }

     void AnsClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new endExercise());
    }
    async void WrongClicked(object sender, EventArgs e)
    {
        bool wrng = await DisplayAlert("Wrong Answer!", " ", "", "Try Again");
        if (wrng)
        {
            App.Current.MainPage = new NavigationPage(new Question10());
        }
        else
        {
            App.Current.MainPage = new NavigationPage(new Question10());
        }
    }
}