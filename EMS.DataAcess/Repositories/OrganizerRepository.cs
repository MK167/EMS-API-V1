using EMS.DataAcess.Interfaces;
using EMS.Entity;
using EMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DataAcess.Repositories
{
    public class OrganizerRepository : Repository<OrganizerEntity>, IOrganizerRepository
    {
        public OrganizerRepository(DbContext context) : base(context)
        {
        }
    }
}
