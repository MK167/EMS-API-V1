using EMS.DataAcess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DataAcess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEventAttendanceRepository EventAttendanceRepository { get; }
        IEventCategoryRepository EventCategoryRepository { get; }
        IEventDetailsRepository EventDetailsRepository { get; }
        IEventStatusRepository EventStatusRepository { get; }
        IEventVenueRepository EventVenueRepository { get; }
        IGenderRepository GenderRepository { get; }
        IJobRepository JobRepository { get; }
        INationalityRepository NationalityRepository { get; }
        IOrganizerRepository OrganizerRepository { get; }
        IUniversityRepository UniversityRepository { get; }
        IUserAdminRepository UserAdminRepository { get; }
        IUserAttendRepository UserAttendRepository { get; }
        IUserImageRepository UserImageRepository { get; }
        IUserTypeRepository UserTypeRepository { get; }

        int Complete();

    }
}
