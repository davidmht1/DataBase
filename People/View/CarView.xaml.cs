using People.Models;

namespace People.View;

public partial class CarView : ContentPage
{
	public CarView()
	{
		InitializeComponent();
	}

    public void OnNewButtonCarClicked(object sender, EventArgs args)
    {
        CarMessage.Text = "";

        App.PersonRepo.AddNewPerson(newModel.Text);
        CarMessage.Text = App.PersonRepo.StatusMessage;
    }

    public void OnGetButtonCarClicked(object sender, EventArgs args)
    {
        CarMessage.Text = "";

        List<Cars> people = App.CarRepo.GetAllCars();
        carsList.ItemsSource = people;
    }
}