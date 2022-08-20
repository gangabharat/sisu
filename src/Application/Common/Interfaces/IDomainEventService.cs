using sisu.Domain.Common;
using System.Threading.Tasks;

namespace sisu.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
