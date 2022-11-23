using OVB.Libraries.Notification.Abstractions.Item;

namespace OVB.Libraries.Notification.Abstractions.Consumer;

public abstract class NotificationConsumerBase<NotificationItemAbstraction, NotifiableContainerAbstraction>
    where NotifiableContainerAbstraction : NotifiableContainerBase<NotificationItemAbstraction>
    where NotificationItemAbstraction : NotificationItemBase
{
    private NotifiableContainerAbstraction Notifiable { get; init; }

    protected NotificationConsumerBase(NotifiableContainerAbstraction notifiableContainer)
    {
        Notifiable = notifiableContainer;
    }

    public List<NotificationItemAbstraction> GetNotificationItems()
    {
        return Notifiable.NotificationItems;
    }
}
