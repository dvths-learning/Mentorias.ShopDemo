using McbEdu.Mentorias.ShopDemo.Domain.Models.Entities.Notification.Content;

namespace McbEdu.Mentorias.ShopDemo.Domain.Models.Entities.Notification.Consumer;

public class NotifiableConsumerStandard
{
    public NotifiableBase Notifiable { get; }

    public NotifiableConsumerStandard(NotifiableBase notifiable)
    {
        Notifiable = notifiable;
    }
}
