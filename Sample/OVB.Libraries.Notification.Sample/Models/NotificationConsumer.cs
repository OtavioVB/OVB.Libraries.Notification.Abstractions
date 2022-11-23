using OVB.Libraries.Notification.Abstractions;
using OVB.Libraries.Notification.Abstractions.Consumer;

namespace OVB.Libraries.Notification.Sample.Models;

public class NotificationConsumer : NotificationConsumerBase<NotifiableContainerBase>
{
    public NotificationConsumer(NotifiableContainerBase notifiableContainer) : base(notifiableContainer)
    {
    }
}
