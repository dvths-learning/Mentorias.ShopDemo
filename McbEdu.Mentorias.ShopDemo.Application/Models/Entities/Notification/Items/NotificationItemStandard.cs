using McbEdu.Mentorias.ShopDemo.Domain.Models.ENUMs;

namespace McbEdu.Mentorias.ShopDemo.Domain.Models.Entities.Notification.Items;

public class NotificationItemStandard : NotificationItemBase
{
    public NotificationItemStandard(string title, string message) 
        : base(title, message, TypeNotification.Standard)
    {

    }
}
