namespace StrategyPattern;

public class ShippingStrategyFedex : IShippingStrategy
{
    public string providerName => "Fedex";

    public decimal CalculateCost(Order order) => order.TotalWeight * 1.5m;
   
}
