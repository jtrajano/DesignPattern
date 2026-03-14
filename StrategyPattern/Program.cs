// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StrategyPattern;

  var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                
                services.AddTransient<IShippingStrategy, ShippingStrategyDHL>();
                services.AddTransient<IShippingStrategy, ShippingStrategyFedex>();
                services.AddTransient<IShippingStrategy, ShippingStrategyUPS>();
                services.AddTransient<OrderProcessor>();
            
            })
            .Build();


var shippingProvider = host.Services.GetRequiredService<OrderProcessor>();


var order = new Order {Name="Fruit", TotalWeight= 100};
var cost = shippingProvider.Process(order, "DHL");

Console.WriteLine($"DHL : {cost}");


cost = shippingProvider.Process(order, "UPS");

Console.WriteLine($"UPS : {cost}");
cost = shippingProvider.Process(order, "Fedex");

Console.WriteLine($"Fedex : {cost}");






    
