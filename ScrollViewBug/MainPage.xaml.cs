namespace ScrollViewBug;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		BindableLayout.SetItemsSource(stack, Enumerable.Range(0, 200).ToList());
    }

}


