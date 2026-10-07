
public class MapService
{
    private readonly List<MapMarker> _markers = new();
    private readonly MarkerStyleFactory _styleFactory;

    public MapService(MarkerStyleFactory styleFactory)
    {
        _styleFactory = styleFactory;
    }

    public void AddPharmacy(string address, double lat, double lon) =>
        AddMarker("Аптека", address, lat, lon);

    public void AddCafe(string address, double lat, double lon) =>
        AddMarker("Кафе", address, lat, lon);

    public void AddShop(string address, double lat, double lon) =>
        AddMarker("Магазин", address, lat, lon);

    public void AddHospital(string address, double lat, double lon) =>
        AddMarker("Больница", address, lat, lon);

    public void AddGasStation(string address, double lat, double lon) =>
        AddMarker("Автозаправочная станция", address, lat, lon);

    private void AddMarker(string category, string address, double lat, double lon)
    {
        MarkerStyle style = _styleFactory.GetStyle(category);
        _markers.Add(new MapMarker(address, lat, lon, style));
    }

    public void DisplayMap()
    {
        Console.WriteLine("ОБЪЕКТЫ НА КАРТЕ ");
        foreach (var marker in _markers)
        {
            marker.Display();
        }
    }

    public int GetMarkersCount() => _markers.Count;
}
