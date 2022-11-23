using OVB.Libraries.Notification.Abstractions;
using OVB.Libraries.Notification.Abstractions.Consumer;
using OVB.Libraries.Notification.Abstractions.Item;
using OVB.Libraries.Notification.Abstractions.Publisher;
using OVB.Libraries.Notification.Sample.Models;

namespace OVB.Libraries.Notification.Sample;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<NotifiableContainerBase, NotificationContainer>();
        builder.Services.AddTransient<NotificationConsumerBase<NotificationContainer>, NotificationConsumer>();
        builder.Services.AddTransient<NotificationPublisherBase<NotificationContainer>, NotificationPublisher>();
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}