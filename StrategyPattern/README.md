

### dotnet add package Microsoft.Extensions.DependencyInjection

```

using Microsoft.Extensions.DependencyInjection;
    services.AddTransient<IShippingStrategy, ShippingStrategyDHL>();
    services.AddTransient<IShippingStrategy, ShippingStrategyFedex>();
    services.AddTransient<IShippingStrategy, ShippingStrategyUPS>();
```

### dotnet add package Microsoft.Extensions.Hosting

```

```


https://www.youtube.com/watch?v=CGRGun-Bw40