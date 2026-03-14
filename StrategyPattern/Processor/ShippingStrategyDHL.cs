namespace StrategyPattern;

public class ShippingStrategyDHL : IShippingStrategy
{
    public string providerName => "DHL";

    public decimal CalculateCost(Order order) => order.TotalWeight * 2.5m;
   
}
