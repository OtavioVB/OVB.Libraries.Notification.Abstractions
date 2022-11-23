using OVB.Libraries.Notification.Abstractions.Item;

namespace OVB.Libraries.Notification.Abstractions.Publisher;

public abstract class NotificationPublisherBase<NotificationItemAbstraction, NotifiableContainerAbstraction>
    where NotificationItemAbstraction : NotificationItemBase
    where NotifiableContainerAbstraction : NotifiableContainerBase<NotificationItemAbstraction>
{
    private NotifiableContainerAbstraction Notifiable { get; init; }

    protected NotificationPublisherBase(NotifiableContainerAbstraction notifiable) 
    { 
        Notifiable = notifiable;
    }

    public void AddNotification(NotificationItemAbstraction notificationItem)
    {
        Notifiable.AddNotification(notificationItem);
    }

    public void AddNotifications(List<NotificationItemAbstraction> notificationItems)
    {
        Notifiable.AddNotifications(notificationItems);
    }
}


