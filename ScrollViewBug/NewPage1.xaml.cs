namespace ScrollViewBug;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
        collection.ItemsSource = Enumerable.Range(0, 200).ToList();
    }
}
