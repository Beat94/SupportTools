namespace SupportTools;

public partial class ShortAnswer : ContentPage
{
	ListView listView = new ListView();
	
	public ShortAnswer()
	{
		InitializeComponent();
	}

	protected override void OnBindingContextChanged()
	{
		base.OnBindingContextChanged();

		listView.SetBinding(ItemsView.ItemsSourceProperty, "ShortAnswers");
		// Add some function to fill list;
		
	}
}
