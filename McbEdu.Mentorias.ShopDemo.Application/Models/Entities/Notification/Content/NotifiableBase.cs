using McbEdu.Mentorias.ShopDemo.Domain.Models.Entities.Notification.Items;

namespace McbEdu.Mentorias.ShopDemo.Domain.Models.Entities.Notification.Content;

public abstract class NotifiableBase
{
    private List<NotificationItemBase> Notifications;

    protected NotifiableBase() 
    { 
        Notifications = new List<NotificationItemBase>();
    }

    public void AddNotification(NotificationItemBase notification)
    {
        Notifications.Add(notification);
    }

    public void AddNotifications(List<NotificationItemBase> notifications)
    {
        this.Notifications.AddRange(notifications);
    }

    public IEnumerable<NotificationItemBase> GetNotifications()
    {
        return this.Notifications;
    }
}
