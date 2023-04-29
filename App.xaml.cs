using Standard_Calculator.StandardCalc;

namespace Standard_Calculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new WelcomeScreen();
	}
}
