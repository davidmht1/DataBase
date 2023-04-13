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

        App.CarRepo.AddNewCar(newModel.Text);
        CarMessage.Text = App.CarRepo.CarMessage;
    }

    public void OnGetButtonCarClicked(object sender, EventArgs args)
    {
        CarMessage.Text = "";

        List<Cars> cars = App.CarRepo.GetAllCars();
        carsList.ItemsSource = cars;
    }
}