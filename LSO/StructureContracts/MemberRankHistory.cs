namespace LSO.StructureContracts;

/// <summary>
/// История должностей бойца отряда
/// </summary>
public class MemberRankHistory
{
    /// <summary>
    /// Год
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// Должность в отряде
    /// </summary>
    public MemberRank MemberRank { get; set; }
    
    /// <summary>
    /// UID бойца отряда
    /// </summary>
    public int SquadMemberId { get; set; }

    /// <summary>
    /// Боец отряда
    /// </summary>
    public SquadMember SquadMember { get; set; }
}