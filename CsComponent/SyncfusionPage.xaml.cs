using Microsoft.UI.Xaml.Controls;
using Syncfusion.UI.Xaml.DataGrid;

namespace CsComponent;

public sealed partial class SyncfusionPage : Page
{
    public SyncfusionPage()
    {
        this.InitializeComponent();
        SfDataGrid sfDataGrid = new SfDataGrid();
        rootGrid.Children.Add(sfDataGrid);

        ViewModel viewModel = new ViewModel();
        sfDataGrid.ItemsSource = viewModel.Orders;
    }
}
