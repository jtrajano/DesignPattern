namespace StrategyPattern;

public class ShippingStrategyUPS : IShippingStrategy
{
    public string providerName => "UPS";

    public decimal CalculateCost(Order order) => order.TotalWeight * 2;
    
}
