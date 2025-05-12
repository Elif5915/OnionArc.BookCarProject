namespace OnionCarBook.Domain.Entities;
public class Pricing
{ //Pricing : Fiyatlandırma
    public int PricingId { get; set; }
    public string Name { get; set; }
    public List<CarPricing> CarPricings { get; set; }
}

