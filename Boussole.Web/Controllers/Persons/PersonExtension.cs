using Boussole.Persons;
using Boussole.Web.Controllers.Persons.Requests;

namespace Boussole.Web.Controllers.Persons;

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