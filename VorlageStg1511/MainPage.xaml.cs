using Windows.Devices.Lights.Effects;

namespace VorlageStg1511;

//Name, Vorname:
//Diese Seite muss am Ende ausgedruckt werden.
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		//Hier beginnt Ihr Code
		WotkItem wotkItem = new WotkItem();
		BindingContext= wotkItem;

		Grid views = new Grid()
		{
			BackgroundColor = Colors.Magenta,
			RowDefinitions =
			{
				//Zeilen Anzahl im Programm
				new RowDefinition(),
				new RowDefinition()
            }
		};
		Content = views;

		//Erstellen eines Labels
		Label label = new Label();
		label.SetBinding(Label.TextProperty, "Message");
		views.Add(label,1,0);

		//Erstellen eines Buttons
		Button button = new Button();
		button.SetBinding(Button.TextProperty, "ButtonText");
		views.Add(button,0,1);

		//TapGestureRecognizer erzeugen und das Label und den Button hinzufügen
		TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
		tapGestureRecognizer.Tapped += Button_Tap;
		button.GestureRecognizers.Add(tapGestureRecognizer);
		label.GestureRecognizers.Add(tapGestureRecognizer);
		//Hier endet Ihr Code
	}

	//Button_Tap Methode um einen DisplayAlert zu erzeugen
    private void Button_Tap(object sender, TappedEventArgs e)
    {
		//DisplayAlert("Debug", "gedrückt", "ok");
		if (sender is Button btn)
		{
            btn.Text = "gedrückt";
        }
		else 
		{
			DisplayAlert("Hi", "No", "ja");
		}
		
    }

    //Beginn eigene Methoden

}