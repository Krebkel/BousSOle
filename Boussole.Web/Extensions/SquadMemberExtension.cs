using Boussole.Core.Controllers.LSO.Structure.Requests;
using Boussole.LSO.Contracts.Structure;

namespace Boussole.Core.Extensions;

internal static class SquadMemberMappingExtensions
{
    internal static SquadMember ToSquadMember(this AddSquadMemberRequest request)
    {
        return new SquadMember
        {
            Person = request.Person,
            MemberRank = request.MemberRank,
            YearEnlisted = request.YearEnlisted,
            IsActive = request.IsActive,
            Squad = request.Squad
        };
    }

    internal static SquadMember ToSquadMember(this UpdateSquadMemberRequest request)
    {
        return new SquadMember
        {
            Person = request.Person,
            MemberRank = request.MemberRank,
            YearEnlisted = request.YearEnlisted,
            IsActive = request.IsActive,
            Squad = request.Squad
        };
    }
}