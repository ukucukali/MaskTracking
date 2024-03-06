using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PharmacyManager : ISupplierService
{
    private readonly IApplicantService _applicantService;

    public PharmacyManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }
    
    public void GiveMask(Person person)
    {
        Console.WriteLine($"Mask has been given");
    }
}
