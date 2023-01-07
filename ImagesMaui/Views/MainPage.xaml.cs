using ImagesMaui.ViewModels;

namespace ImagesMaui;

public partial class MainPage : ContentPage
{
	MainViewModel vm;

	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		vm = viewModel;
		BindingContext=vm;
	}

	
}

