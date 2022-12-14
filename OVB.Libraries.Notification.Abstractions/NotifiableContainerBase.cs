using OVB.Libraries.Notification.Abstractions.Item;

namespace OVB.Libraries.Notification.Abstractions;

public abstract class NotifiableContainerBase
{
    public List<NotificationItemBase> NotificationItems { get; init; }

    protected NotifiableContainerBase()
    {
        NotificationItems = new List<NotificationItemBase>();
    }

    public virtual void AddNotification(NotificationItemBase notification)
    {
        NotificationItems.Add(notification);
    }

    public virtual void AddNotifications(List<NotificationItemBase> notifications)
    {
        this.NotificationItems.AddRange(notifications);
    }
}