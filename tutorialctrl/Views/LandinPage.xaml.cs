using tutorialctrl.ViewModels;

namespace tutorialctrl.Views;

public partial class LandinPage : ContentPage
{
	public LandinPage()
	{
		InitializeComponent();
		this.BindingContext = new LandingViewModel();
	}
}