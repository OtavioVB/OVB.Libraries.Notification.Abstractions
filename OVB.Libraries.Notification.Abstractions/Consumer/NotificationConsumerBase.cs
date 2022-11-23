using OVB.Libraries.Notification.Abstractions.Item;

namespace OVB.Libraries.Notification.Abstractions.Consumer;

public abstract class NotificationConsumerBase<NotifiableContainerAbstraction>
    where NotifiableContainerAbstraction : NotifiableContainerBase
{
    private NotifiableContainerAbstraction Notifiable { get; init; }

    protected NotificationConsumerBase(NotifiableContainerAbstraction notifiableContainer)
    {
        Notifiable = notifiableContainer;
    }

    public List<NotificationItemBase> GetNotificationItems()
    {
        return Notifiable.NotificationItems;
    }
}
