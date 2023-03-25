
namespace LoadingImageNative.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

#if __IOS__
        var imageNames = new List<string>();
        var bundle = Foundation.NSBundle.MainBundle;

        foreach (var imageName in Foundation.NSBundle.MainBundle.PathsForResources("png", null))
        {
            imageNames.Add(System.IO.Path.GetFileNameWithoutExtension(imageName));
        }
#endif 
    }
}


