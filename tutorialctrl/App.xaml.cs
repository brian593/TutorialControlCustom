using tutorialctrl.Views;

namespace tutorialctrl;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new LandinPage());
	}
}
