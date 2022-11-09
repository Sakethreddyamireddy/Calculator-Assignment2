namespace Calculator;

public partial class simpleExercise : ContentPage
{
	public simpleExercise()
	{
		InitializeComponent();
	}
	void Question1_clicked(object sender, EventArgs e)
	{
        App.Current.MainPage = new NavigationPage(new Question1());
    }
}