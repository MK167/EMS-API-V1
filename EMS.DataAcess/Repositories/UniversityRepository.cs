using EMS.DataAcess.Interfaces;
using EMS.Entity;
using EMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DataAcess.Repositories
{
    public class UniversityRepository : Repository<UniversityEntity>, IUniversityRepository
    {
        public UniversityRepository(DbContext context) : base(context)
        {
        }
    }
}
