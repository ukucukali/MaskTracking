using Business.Concrete;
using Entities.Concrete;

Person person = new ()
{
    FirstName = "UĞUR",
    LastName = "TEST",
    BirthYear = 1995,
    NationalityNumber = 1
};

PttManager pttManager = new(new CitizenManager(),new CustomerCheckManager());
pttManager.GiveMask(person);


PharmacyManager pharmacyManager = new(new ForeignerManager());
pharmacyManager.GiveMask(person);


MarketManager manager = new();
manager.SellMask();
