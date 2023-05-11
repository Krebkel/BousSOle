namespace LSO;

/// <summary>
/// Линейный студенческий отряд
/// </summary>
public class Squad
{
    /// <summary>
    /// Название ЛСО (ССО "Агонь")
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Регион, в котором находится штаб (г. Москва)
    /// </summary>
    public string Region { get; set; }
    /// <summary>
    /// Ссылка на ВК отряда (https://vk.com/ssoagon)
    /// </summary>
    public string VKUrl { get; set; }
    /// <summary>
    /// Учебное заведение базирования (ФГБОУ ВО МАДИ)
    /// </summary>
    public Institution Institution { get; set; }
}

