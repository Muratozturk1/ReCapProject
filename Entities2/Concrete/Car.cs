using Entities2.Abstract;

namespace Entities2.Concrete;
public class Car : IEntity
{
    public int CarId { get; set; }
    public int BrandId { get; set; }
    public int ColorId { get; set; }
    public int DailyPrice { get; set; }
    public string Description { get; set; } = string.Empty;
    public int ModelYear { get; set; }
}

