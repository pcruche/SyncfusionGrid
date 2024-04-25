using Microsoft.UI.Xaml;

namespace CsComponent;

public sealed class Dialog : Window
{
    public Dialog()
    {
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");
        SetPageContent();
    }

    private void SetPageContent()
    {
        var page = new SyncfusionPage();
        Content = page;
    }
}