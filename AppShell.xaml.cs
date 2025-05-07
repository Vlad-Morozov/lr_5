using Astronomy.Pages; 
namespace Astronomy;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        
        Routing.RegisterRoute(nameof(MoonPhasePage), typeof(MoonPhasePage));
        Routing.RegisterRoute(nameof(SunrisePage), typeof(SunrisePage));
        Routing.RegisterRoute(nameof(AstronomicalBodiesPage), typeof(AstronomicalBodiesPage));
        Routing.RegisterRoute(nameof(AstronomicalBodyPage), typeof(AstronomicalBodyPage));
        Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
    }
}
