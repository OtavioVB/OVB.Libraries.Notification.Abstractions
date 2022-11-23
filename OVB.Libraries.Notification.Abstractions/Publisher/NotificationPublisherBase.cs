using OVB.Libraries.Notification.Abstractions.Item;

namespace OVB.Libraries.Notification.Abstractions.Publisher;

public abstract class NotificationPublisherBase<NotifiableContainerAbstraction>
    where NotifiableContainerAbstraction : NotifiableContainerBase
{
    private NotifiableContainerAbstraction Notifiable { get; init; }

    protected NotificationPublisherBase(NotifiableContainerAbstraction notifiable) 
    { 
        Notifiable = notifiable;
    }

    public void AddNotification(NotificationItemBase notificationItem)
    {
        Notifiable.AddNotification(notificationItem);
    }

    public void AddNotifications(List<NotificationItemBase> notificationItems)
    {
        Notifiable.AddNotifications(notificationItems);
    }
}


