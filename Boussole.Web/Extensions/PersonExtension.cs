using Boussole.Core.Controllers.LSO.Structure.Requests;
using Boussole.LSO.Contracts.Structure;

namespace Boussole.Core.Extensions;

internal static class PersonMappingExtensions
{
    internal static Person ToPerson(this AddPersonRequest request)
    {
        return new Person
        {
            PersonInn = request.PersonInn,
            Surname = request.Surname,
            Name = request.Name,
            Patronymic = request.Patronymic,
            PhoneNumber = request.PhoneNumber,
            EMail = request.EMail
        };
    }
    
    internal static Person ToUpdatePerson(this UpdatePersonRequest request, Person existingPerson)
    {
        existingPerson.PersonInn = request.PersonInn;
        existingPerson.Surname = request.Surname;
        existingPerson.Name = request.Name;
        existingPerson.Patronymic = request.Patronymic;
        existingPerson.PhoneNumber = request.PhoneNumber;
        existingPerson.EMail = request.EMail;

        return existingPerson;
    }
}