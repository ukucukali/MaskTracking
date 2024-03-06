using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PttManager : ISupplierService
{
    private readonly IApplicantService _applicantService;
    private readonly INationalityCheckService _nationalityCheckService;
    public PttManager(IApplicantService applicantService, INationalityCheckService nationalityCheckService)
    {
        _applicantService = applicantService;
        _nationalityCheckService = nationalityCheckService;
    }
    
    public void GiveMask(Person person)
    {
        if( _nationalityCheckService.CheckPerson(person))
            Console.WriteLine($"Mask given to {person.FirstName}");
        else
            Console.WriteLine($"Mask could not be given to {person.FirstName}");
    }
}
