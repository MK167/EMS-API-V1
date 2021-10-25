using EMS.DataAcess.Interfaces;
using EMS.Entity;
using EMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DataAcess.Repositories
{
    public class UserAttendRepository : Repository<UserAttendEntity>, IUserAttendRepository
    {
        public UserAttendRepository(DbContext context) : base(context)
        {
        }
    }
}