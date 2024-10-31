namespace DotNetCommunityToolkit.MVVM.Views;

public partial class DemoPage : ContentPage
{
	public DemoPage()
	{
		InitializeComponent();
        BindingContext = new DemoViewModel();
    }
}