using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;

namespace SupportTools;

public class TestClass
{
	public string Name{get; set;}
	public string Text2{get; set;}
}

public class ManagerClass
{
	private int count = 0;
	public ObservableCollection<TestClass> lolz{get;} = new ObservableCollection<TestClass>();

	public void addAnswers()
	{
		string zahl = count.ToString();
		lolz.Add(new TestClass{Name = "Antwort", Text2 = zahl.ToString()});
		Console.WriteLine(lolz.Count.ToString());
		count++;
	}

	public string TestString{get;} = "Data out of Managerclass";
}

public partial class ShortAnswer : ContentPage
{
	//public ObservableCollection<Answer> shortAnswers = new ObservableCollection<Answer>();

	public ShortAnswer()
	{
		InitializeComponent();
		ManagerClass mc = new();
	
		mc.addAnswers();

		TestClass tc = new()
		{
			Name = "Backend-Text",
			Text2 = "Dies ist der 2. Backend-Text"
		};

		BindingContext = new {mc, tc};
		//BindingContext = tc;
	}
}
