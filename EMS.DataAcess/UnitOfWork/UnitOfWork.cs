using EMS.DataAcess.Interfaces;
using EMS.DataAcess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DataAcess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _Context;
        public UnitOfWork(DbContext context)
        {
            _Context = context;
            EventAttendanceRepository = new EventAttendanceRepository(_Context);
            EventCategoryRepository = new EventCategoryRepository(_Context);
            EventDetailsRepository = new EventDetailsRepository(_Context);
            EventStatusRepository = new EventStatusRepository(_Context);
            EventVenueRepository = new EventVenueRepository(_Context);
            GenderRepository = new GenderRepository(_Context);
            JobRepository = new JobRepository(_Context);
            NationalityRepository = new NationalityRepository(_Context);
            OrganizerRepository = new OrganizerRepository(_Context);
            UniversityRepository = new UniversityRepository(_Context);
            UserAdminRepository = new UserAdminRepository(_Context);
            UserAttendRepository = new UserAttendRepository(_Context);
            UserImageRepository = new UserImageRepository(_Context);
            UserTypeRepository = new UserTypeRepository(_Context);
        }

        public IEventAttendanceRepository EventAttendanceRepository { get; private set; }

        public IEventCategoryRepository EventCategoryRepository { get; private set; }

        public IEventDetailsRepository EventDetailsRepository { get; private set; }

        public IEventStatusRepository EventStatusRepository { get; private set; }

        public IEventVenueRepository EventVenueRepository { get; private set; }

        public IGenderRepository GenderRepository { get; private set; }

        public IJobRepository JobRepository { get; private set; }

        public INationalityRepository NationalityRepository { get; private set; }

        public IOrganizerRepository OrganizerRepository { get; private set; }

        public IUniversityRepository UniversityRepository { get; private set; }

        public IUserAdminRepository UserAdminRepository { get; private set; }

        public IUserAttendRepository UserAttendRepository { get; private set; }

        public IUserImageRepository UserImageRepository { get; private set; }

        public IUserTypeRepository UserTypeRepository { get; private set; }

        public int Complete()
        {
            return _Context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }

            if (_Context == null)
            {
                return;
            }

            _Context.Dispose();
            _Context = null;
        }
    }
}