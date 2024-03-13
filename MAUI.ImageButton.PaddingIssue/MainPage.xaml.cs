using Mopups.Services;

namespace MAUI.ImageButton.PaddingIssue;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        MopupService.Instance.PushAsync(new MyPopup());
    }
}