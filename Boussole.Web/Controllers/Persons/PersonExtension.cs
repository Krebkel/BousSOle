using Boussole.Core.Controllers.Persons.Requests;
using Boussole.Persons;

namespace Boussole.Core.Controllers.Persons;

internal static class PersonMappingExtensions
{
    internal static CreatePersonRequest ToAddPersonRequest(this AddPersonApiRequest apiRequest)
    {
        return new CreatePersonRequest();
    }
    
    internal static UpdatePersonRequest ToUpdatePersonRequest(this UpdatePersonApiRequest request)
    {
        return new UpdatePersonRequest();
    }
}