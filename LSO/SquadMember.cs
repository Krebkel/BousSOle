namespace LSO;

public class SquadMember        // Боец линейного студенческого отряда
{
    public string Name { get; set; }            // ФИО бойца (Иванов Иван Иванович)
    public string PhoneNumber { get; set; }     // Телефон бойца (+7 (999) 999-99-99)
    public int YearEnlisted { get; set; }       // Год набора (2023)
    public bool IsActive { get; set; }          // Участие в действующем составе (Да)
    public Squad Squad { get; set; }            // Отряд (ССО "Агонь")
}
