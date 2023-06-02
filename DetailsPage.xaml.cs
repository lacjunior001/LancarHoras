using LancarHoras.ViewModel;

namespace LancarHoras;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}