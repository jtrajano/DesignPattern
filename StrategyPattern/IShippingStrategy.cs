namespace StrategyPattern;

public interface IShippingStrategy
{
    string providerName { get;}
    decimal CalculateCost(Order order);
}
