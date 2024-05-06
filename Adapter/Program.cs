using Adapter.Adapters;
using Adapter.Interfaces;
using Adapter.Products;

Smartphone smartphone = new Smartphone();
Tablet tablet = new Tablet();

IProduct iSmartphone = new SmartphoneAdapter(smartphone);
IProduct iTablet = new TabletAdapter(tablet);

Console.WriteLine($"Modelo do smartphone: {iSmartphone.GetModel()}");
Console.WriteLine($"Descrição do smartphone: {iSmartphone.GetDescription()}");
Console.WriteLine($"Preço do smartphone: {iSmartphone.GetPrice()}");
Console.WriteLine();
Console.WriteLine($"Modelo do tablet: {iTablet.GetModel()}");
Console.WriteLine($"Descrição do table: {iTablet.GetDescription()}");
Console.WriteLine($"Preço do tablet: {iTablet.GetPrice()}");
