namespace CollectionViewScrollBug;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		BindableLayout.SetItemsSource(stack, Enumerable.Range(0, 200).ToList());
	}
}
