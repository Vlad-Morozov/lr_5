using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Astronomy.Pages;

public partial class AstronomicalBodiesPage : ContentPage
{
    public ObservableCollection<string> Bodies { get; set; }
    public ICommand BodySelectedCommand { get; set; }

    public AstronomicalBodiesPage()
    {
        InitializeComponent();

        // Список астрономічних тіл
        Bodies = new ObservableCollection<string>
        {
            "Moon",
            "Mars",
            "Jupiter",
            "Venus"
        };

        BodySelectedCommand = new Command<string>(async (selectedBody) =>
        {
            if (!string.IsNullOrEmpty(selectedBody))
            {
                await Shell.Current.GoToAsync($"{nameof(AstronomicalBodyPage)}?bodyName={selectedBody}");
            }
        });

        BindingContext = this;
        BodiesList.ItemsSource = Bodies;
    }
}
