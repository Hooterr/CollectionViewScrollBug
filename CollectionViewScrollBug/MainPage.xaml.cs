namespace CollectionViewScrollBug;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		collection.ItemsSource = Enumerable.Range(0, 200).ToList();
	}

}


