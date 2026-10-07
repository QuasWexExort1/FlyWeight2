

var factory = new MarkerStyleFactory();
var mapService = new MapService(factory);

mapService.AddPharmacy("ул. Ленина, 15", 54.7104, 20.4522);
mapService.AddPharmacy("пр-т Мира, 42", 54.7211, 20.4831);
mapService.AddPharmacy("ул. Черняховского, 7", 54.7185, 20.5012);
mapService.AddPharmacy("ул. Горького, 112", 54.7341, 20.4922);
mapService.AddPharmacy("ул. Гагарина, 23", 54.7199, 20.5311);

mapService.AddCafe("ул. Баранова, 2", 54.7192, 20.5045);
mapService.AddCafe("ул. Театральная, 30", 54.7161, 20.4971);
mapService.AddCafe("Ленинский пр-т, 18", 54.7081, 20.5020);
mapService.AddCafe("ул. Пролетарская, 5", 54.7144, 20.5133);
mapService.AddCafe("ул.Комсомольская, 12", 54.7277, 20.4711);

mapService.AddShop("ул. Невского, 36", 54.7299, 20.5211);
mapService.AddShop("ул. Куйбышева, 95", 54.7325, 20.5401);
mapService.AddShop("Московский пр-т, 40", 54.7066, 20.5288);
mapService.AddShop("ул. Дзержинского, 10", 54.6911, 20.5144);
mapService.AddShop("ул. Киевская, 71", 54.6822, 20.4955);

mapService.AddHospital("ул. Клиническая, 74", 54.7155, 20.5233);
mapService.AddHospital("ул. Летняя, 3", 54.6744, 20.5099);
mapService.AddHospital("ул. Чапаева, 26", 54.7222, 20.4588);

mapService.AddGasStation("Московский пр-т, 182", 54.7044, 20.5811);
mapService.AddGasStation("ул. Суворова, 55", 54.6788, 20.4622);
mapService.AddGasStation("пр-т Победы, 140", 54.7099, 20.4133);


mapService.DisplayMap();

Console.WriteLine("\nПРОВЕРКА РАБОТЫ FLYWEIGHT ");

MarkerStyle style1 = factory.GetStyle("Аптека");
MarkerStyle style2 = factory.GetStyle("Аптека");
bool isSamePharmacy = ReferenceEquals(style1, style2);
Console.WriteLine($"Стиль 1 и Стиль 2 для 'Аптека' указывают на один объект: {isSamePharmacy}");

MarkerStyle cafeStyle1 = factory.GetStyle("Кафе");
MarkerStyle cafeStyle2 = factory.GetStyle("Кафе");
bool isSameCafe = ReferenceEquals(cafeStyle1, cafeStyle2);
Console.WriteLine($"Стиль 1 и Стиль 2 для 'Кафе' указывают на один объект: {isSameCafe}");


Console.WriteLine("\n--- СТАТИСТИКА ИСПОЛЬЗОВАНИЯ ПАМЯТИ ---");
Console.WriteLine($"Всего маркеров на карте: {mapService.GetMarkersCount()}");
Console.WriteLine($"Всего создано объектов стилей (MarkerStyle): {factory.GetStylesCount()}");
