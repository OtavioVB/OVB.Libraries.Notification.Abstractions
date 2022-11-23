using OVB.Libraries.Notification.Abstractions.Item;

namespace OVB.Libraries.Notification.Abstractions;

public abstract class NotifiableContainerBase<NotificationItemAbstraction> where NotificationItemAbstraction : NotificationItemBase
{
    public List<NotificationItemAbstraction> NotificationItems { get; init; }

    protected NotifiableContainerBase(List<NotificationItemAbstraction> notificationItems)
    {
        NotificationItems = notificationItems;
    }

    public virtual void AddNotification(NotificationItemAbstraction notification)
    {
        NotificationItems.Add(notification);
    }

    public virtual void AddNotifications(List<NotificationItemAbstraction> notifications)
    {
        this.NotificationItems.AddRange(notifications);
    }
}