using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mopups.Services;

namespace MAUI.ImageButton.PaddingIssue;

public partial class MyPopup
{
    public MyPopup()
    {
        InitializeComponent();
    }

    private async void ImageButton_OnClicked(object? sender, EventArgs e)
    {
        await MopupService.Instance.PopAsync();
    }
}