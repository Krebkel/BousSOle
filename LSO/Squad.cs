namespace LSO;

public class Squad              // Линейный студенческий отряд
{
    public string Name { get; set; }                 // Название ЛСО (ССО "Агонь")
    public string Region { get; set; }               // Регион, в котором находится штаб (г. Москва)
    public string VKUrl { get; set; }                // Ссылка на ВК отряда (https://vk.com/ssoagon)
    public Institution Institution { get; set; }     // Учебное заведение базирования (ФГБОУ ВО МАДИ)
}

