namespace OnionCarBook.Domain.Entities;
public class CarFeature
{
    public int CarFeatureId { get; set; }
    public int CarId { get; set; }
    public Car Car { get; set; } //Navigation Property - Car nesnesini temsil eder. CarFeature kaydına karşılık gelen Car nesnesine erişmek için kullanılır.
    public int FeatureId { get; set; }
    public Feature Feature { get; set; } //Navigation Property - Feature nesnesini temsil 
    public bool Available { get; set; }
}

