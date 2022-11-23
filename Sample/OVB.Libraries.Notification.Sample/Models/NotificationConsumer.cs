using OVB.Libraries.Notification.Abstractions.Consumer;

namespace OVB.Libraries.Notification.Sample.Models;

public class NotificationConsumer : NotificationConsumerBase<NotificationContainer>
{
    public NotificationConsumer(NotificationContainer notifiableContainer) : base(notifiableContainer)
    {
    }
}
