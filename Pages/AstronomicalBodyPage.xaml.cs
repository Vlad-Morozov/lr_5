namespace Astronomy.Pages;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Platform;

[QueryProperty(nameof(BodyName), "bodyName")]
public partial class AstronomicalBodyPage : ContentPage
{
    private string bodyName;

    public string BodyName
    {
        get => bodyName;
        set
        {
            bodyName = value;
            UpdateContent();
        }
    }

    public AstronomicalBodyPage()
    {
        InitializeComponent();
    }

    private void UpdateContent()
    {
        if (string.IsNullOrEmpty(BodyName))
            return;

        var name = BodyName.ToLower();

        switch (name)
        {
            case "sun":
                BodyTitleLabel.Text = "The Sun";
                BodyImage.Source = "sun.png"; // Іконка Сонця
                MassLabel.Text = "1.989 × 10^30 kg";
                CircumferenceLabel.Text = "4,379,000 km";
                AgeLabel.Text = "4.603 billion years";
                break;

            case "moon":
                BodyTitleLabel.Text = "The Moon";
                BodyImage.Source = "moon.png"; // Іконка Місяця
                MassLabel.Text = "7.347 × 10^22 kg";
                CircumferenceLabel.Text = "10,921 km";
                AgeLabel.Text = "4.53 billion years";
                break;

            default:
                BodyTitleLabel.Text = BodyName;
                BodyImage.Source = "question.png"; // Стандартна іконка для інших тіл
                MassLabel.Text = "Unknown";
                CircumferenceLabel.Text = "Unknown";
                AgeLabel.Text = "Unknown";
                break;
        }
    }
}
