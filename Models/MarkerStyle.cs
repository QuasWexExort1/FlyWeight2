public class MarkerStyle
{
    public string Category { get; }
    public string Icon { get; }
    public string Color { get; }

    public MarkerStyle(string category, string icon, string color)
    {
        Category = category;
        Icon = icon;
        Color = color;
    }

    public void Redner()
    {
        Console.WriteLine(
            $"Категория - {Category}" +
            $"Иконка - {Icon}" +
            $"Цвет - {Color}"
            );
    }
}
