using Microsoft.AspNetCore.Mvc;
using OVB.Libraries.Notification.Abstractions;
using OVB.Libraries.Notification.Abstractions.Consumer;
using OVB.Libraries.Notification.Abstractions.Publisher;
using OVB.Libraries.Notification.Sample.Models;

namespace OVB.Libraries.Notification.Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(
            [FromServices] NotificationPublisherBase<NotifiableContainerBase> publisherNotification,
            [FromServices] NotificationConsumerBase<NotifiableContainerBase> consumerNotification)
        {
            publisherNotification.AddNotification(new NotificationItem("Notificação 1."));
            publisherNotification.AddNotification(new NotificationItem("Notificação 2."));
            return StatusCode(200, consumerNotification.GetNotificationItems());
        }
    }
}