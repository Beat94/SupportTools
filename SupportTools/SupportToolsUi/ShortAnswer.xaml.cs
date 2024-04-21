using System.Collections.ObjectModel;

namespace SupportTools;

public partial class ShortAnswer : ContentPage
{
	ObservableCollection<Answer> shortAnswers = new ObservableCollection<Answer>();
	
	public ShortAnswer()
	{
		InitializeComponent();
		shortAnswers.Add(new Answer("Test", null));
		
		//listView.SetBinding(ItemsView.ItemsSourceProperty, "ShortAnswers");
	}

	protected override void OnBindingContextChanged()
	{
		base.OnBindingContextChanged();

		
		// Add some function to fill list;
		
	}
}
