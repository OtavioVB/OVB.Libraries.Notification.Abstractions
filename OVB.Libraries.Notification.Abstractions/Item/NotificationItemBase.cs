namespace OVB.Libraries.Notification.Abstractions.Item;

public abstract class NotificationItemBase
{
    public string Message { get; init; }

    protected NotificationItemBase(string message)
    {
        Message = message;
    }
}
