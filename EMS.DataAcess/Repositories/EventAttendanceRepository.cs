using EMS.DataAcess.Interfaces;
using EMS.Entity;
using EMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DataAcess.Repositories
{
    public class EventAttendanceRepository : Repository<EventAttendanceEntity>, IEventAttendanceRepository
    {
        public EventAttendanceRepository(DbContext context) : base(context)
        {
        }
    }
}