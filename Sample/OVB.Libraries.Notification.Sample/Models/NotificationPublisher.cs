using OVB.Libraries.Notification.Abstractions.Publisher;

namespace OVB.Libraries.Notification.Sample.Models;

public class NotificationPublisher : NotificationPublisherBase<NotificationContainer>
{
    public NotificationPublisher(NotificationContainer notifiable) : base(notifiable)
    {
    }
}
