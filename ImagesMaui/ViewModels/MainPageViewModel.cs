using CommunityToolkit.Mvvm.ComponentModel;

namespace ImagesMaui.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    Image img;

    [ObservableProperty]
    string nadpis;

    public MainViewModel()
    {
        Image image = new Image
        {
            Source = ImageSource.FromFile("lock1.png")
        };

        Img = image;

        Nadpis = "Welcome to .Net Maui";
    }
}
