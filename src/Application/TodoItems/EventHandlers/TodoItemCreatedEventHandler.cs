using sisu.Application.Common.Models;
using sisu.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace sisu.Application.TodoItems.EventHandlers
{
    public class TodoItemCreatedEventHandler : INotificationHandler<DomainEventNotification<TodoItemCreatedEvent>>
    {
        private readonly ILogger<TodoItemCreatedEventHandler> _logger;

        public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(DomainEventNotification<TodoItemCreatedEvent> notification, CancellationToken cancellationToken)
        {
            var domainEvent = notification.DomainEvent;

            _logger.LogInformation("sisu Domain Event: {DomainEvent}", domainEvent.GetType().Name);

            return Task.CompletedTask;
        }
    }
}
