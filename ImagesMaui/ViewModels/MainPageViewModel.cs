using CommunityToolkit.Mvvm.ComponentModel;

namespace ImagesMaui.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    Image img;

    [ObservableProperty]
    string nadpis;

    [ObservableProperty]
    Uri imgPath;

    public MainViewModel()
    {

        Nadpis = "Welcome to .Net Maui";

        ImgPath = new Uri("https://aka.ms/campus.jpg");

        Image image = new Image
        {
            Source = ImageSource.FromUri(new Uri("https://aka.ms/campus.jpg"))// ImageSource.FromFile("lock1.png")
        };

        Img = image;
        Img.Aspect = Aspect.AspectFill;

        
    }
}
