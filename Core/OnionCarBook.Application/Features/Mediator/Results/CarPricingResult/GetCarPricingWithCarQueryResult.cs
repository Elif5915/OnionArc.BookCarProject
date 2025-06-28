namespace OnionCarBook.Application.Features.Mediator.Results.CarPricingResult;
public class GetCarPricingWithCarQueryResult
{
    public int CarPricingId { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal Amount { get; set; }
    public string CoverImageUrl { get; set; }
}
