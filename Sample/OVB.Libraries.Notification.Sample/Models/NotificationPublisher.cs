using OVB.Libraries.Notification.Abstractions;
using OVB.Libraries.Notification.Abstractions.Publisher;

namespace OVB.Libraries.Notification.Sample.Models;

public class NotificationPublisher : NotificationPublisherBase<NotifiableContainerBase>
{
    public NotificationPublisher(NotifiableContainerBase notifiable) : base(notifiable)
    {
    }
}
