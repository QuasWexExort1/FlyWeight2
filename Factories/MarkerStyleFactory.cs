public class MarkerStyleFactory
{
    private readonly Dictionary<string, MarkerStyle> _styles = new();

    public MarkerStyle GetStyle(string category)
    {
        if (_styles.TryGetValue(category, out var existingStyle))
        {
            return existingStyle;
        }

        var (icon, color) = category switch
        {
            "Аптека" => ("pharmacy.png", "Green"),
            "Кафе" => ("cafe.png", "Brown"),
            "Магазин" => ("shop.png", "Blue"),
            "Больница" => ("hospital.png", "Red"),
            "Автозаправочная станция" => ("gas.png", "Yellow"),
            _ => ("default.png", "White")
        };

        var newStyle = new MarkerStyle(category, icon, color);
        _styles.Add(category, newStyle);
        return newStyle;
    }

    public int GetStylesCount() => _styles.Count;
}
