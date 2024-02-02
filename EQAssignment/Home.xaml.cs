namespace EQAssignment;

public partial class Home : ContentPage
{
    
    
    
    
    public Home()
	{
		InitializeComponent();
        Routing.RegisterRoute("UI", typeof(UI));
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//UI");
    }
   
}