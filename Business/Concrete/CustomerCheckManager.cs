using Business.Abstract;
using Business.KPSPublic;
using Entities.Concrete;

namespace Business.Concrete;

public class CustomerCheckManager: INationalityCheckService
{
    public bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikNoDogrulaAsync(
                person.NationalityNumber,
                person.FirstName,
                person.LastName,
                person.BirthYear).Result.Body
            .TCKimlikNoDogrulaResult;
    }
}
