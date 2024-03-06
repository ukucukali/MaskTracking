using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class MarketManager: ISellerService
{
    public void SellMask()
    {
        Console.WriteLine("Mask sold");
    }
}
