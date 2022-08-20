using sisu.Application.Common.Interfaces;
using System;

namespace sisu.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
