public class MapMarker
{
    public string Address { get; }
    public double Latitude { get; }
    public double Longitude { get; }
    public MarkerStyle Style { get; }

    public MapMarker(string address, double latitude, double longitude, MarkerStyle style)
    {
        Address = address;
        Latitude = latitude;
        Longitude = longitude;
        Style = style;
    }

    public void Display()
    {
        Console.WriteLine($"|Адрес: {Address,-20} | Координаты: {Latitude}, {Longitude}");
    }
}
