using Business.Abstract;
using Business.KPSPublic;
using Entities.Concrete;

namespace Business.Concrete;

public class CitizenManager :BasePersonManager, IApplicantService
{
   public void ApplyForMask(Person person)
   {
       Console.WriteLine("Applied for mask");
   }
   
   public List<Person> GetPersons()
   {
       return null;
   }
}
