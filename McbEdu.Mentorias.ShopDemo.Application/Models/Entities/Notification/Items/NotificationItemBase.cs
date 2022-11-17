namespace McbEdu.Mentorias.ShopDemo.Domain.Models.Entities.Notification.Items;

public abstract class NotificationItemBase
{
    public string Title { get; }
    public string Message { get; }

    protected NotificationItemBase(string title, string message)
    {
        Title = title;
        Message = message;
    }
}
