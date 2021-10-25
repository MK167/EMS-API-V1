using EMS.DataAcess.Interfaces;
using EMS.Entity;
using EMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DataAcess.Repositories
{
    public class UserTypeRepository : Repository<UserTypeEntity>, IUserTypeRepository
    {
        public UserTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
