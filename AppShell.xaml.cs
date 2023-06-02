using LancarHoras.Models.LoginOnBase;

namespace LancarHoras;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
    }

}
