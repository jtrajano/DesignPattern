using StrategyPattern;

public class OrderProcessor
{
    Dictionary<string, IShippingStrategy> dictShippingStrategy;
    public OrderProcessor(IEnumerable<IShippingStrategy> shippingStrategies)
    {
        dictShippingStrategy = shippingStrategies
            .ToDictionary(c=> c.providerName, c=> c);
    }

    public decimal Process(Order order, string providerName )
    {
        if(!dictShippingStrategy.TryGetValue(providerName, out var shippingStrategy ))
            throw new Exception($"Unknown provider: {providerName}");

        return shippingStrategy.CalculateCost(order);

    }
}