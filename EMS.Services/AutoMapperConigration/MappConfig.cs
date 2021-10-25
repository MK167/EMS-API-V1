using AutoMapper;
using EMS.Entity;
using EMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Services.AutoMapperConigration
{
    public class MappConfig : Profile
    {
        public MappConfig()
        {
            mappEventAttendance();
            mappEventCategory();
            mappEventDetails();
            mappEventStatus();
            mappEventVenue();
            mappGender();
            mappJob();
            mappNationality();
            mappOrganizer();
            mappUniversity();
            mappUserAdmin();
            mappUserAttend();
            mappUserImage();
            mappUserType();
        }

        private void mappUserType()
        {
            CreateMap<UserTypeDTO, UserTypeEntity>()
            .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.UserTypeID))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.UserTypeName))
            .ReverseMap();
        }

        private void mappUserImage()
        {
            CreateMap<UserImageDTO, UserImageEntity>()
            .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.UserImageID))
            .ForMember(dest => dest.ImgPath, opt => opt.MapFrom(src => src.ImgPathName))

            .ReverseMap();
        }

        private void mappUserAttend()
        {
            CreateMap<UserAttendDTO, UserAttendEntity>()
            .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.UserAttendID))
            .ReverseMap()
            .ForMember(dest => dest.UniversityName, opt => opt.MapFrom(src => src.University == null ? "" : src.University.Name))
            .ForMember(dest => dest.UserTypeName, opt => opt.MapFrom(src => src.UserType == null ? "" : src.UserType.Name))
            .ForMember(dest => dest.NationalityName, opt => opt.MapFrom(src => src.Nationality == null ? "" : src.Nationality.Name))
            .ForMember(dest => dest.GenderName, opt => opt.MapFrom(src => src.Gender == null ? "" : src.Gender.Name));

        }

        private void mappUserAdmin()
        {
            CreateMap<UserAdminDTO, UserAdminEntity>()
            .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.UserAdminID))
            .ReverseMap()
            .ForMember(dest => dest.JobName, opt => opt.MapFrom(src => src.Job == null ? "" : src.Job.Name))
            .ForMember(dest => dest.ImgPathName, opt => opt.MapFrom(src => src.UsrerImage == null ? "" : src.UsrerImage.ImgPath));
        }

        private void mappUniversity()
        {
            CreateMap<UniversityDTO, UniversityEntity>()
                        .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.UniversityID))
                        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.UniversityName))
                        .ReverseMap();
        }

        private void mappOrganizer()
        {
            CreateMap<OrganizerDTO, OrganizerEntity>()
                        .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.OrganizerID))
                        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.OrganizerName))
                        .ReverseMap();
        }

        private void mappNationality()
        {
            CreateMap<NationalityDTO, NationalityEntity>()
                        .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.NationalityID))
                        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NationalityName))
                        .ReverseMap();
        }

        private void mappJob()
        {
            CreateMap<JobDTO, JobEntity>()
                        .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.JobID))
                        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.jobName))
                        .ReverseMap();
        }

        private void mappGender()
        {
            CreateMap<GenderDTO, GenderEntity>()
                        .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.GenderID))
                        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.GenderName))
                        .ReverseMap();
        }

        private void mappEventVenue()
        {
            CreateMap<EventVenueDTO, EventVenueEntity>()
                        .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.EventVenueID))
                        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.EventVenueName))
                        .ReverseMap();
        }

        private void mappEventStatus()
        {
            CreateMap<EventStatusDTO, EventStatusEntity>()
                       .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.EventStatusID))
                        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.EventStatusName))
                       .ReverseMap();
        }

        private void mappEventDetails()
        {
            CreateMap<EventDetailsDTO, EventDetailsEntity>()
                       .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.EventDetailsID))
                        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.EventDetailsName))
                       .ReverseMap()
                       .ForMember(dest => dest.OrganizerName, opt => opt.MapFrom(src => src.Organizer == null ? "" : src.Organizer.Name))
                       .ForMember(dest => dest.EventStatusName, opt => opt.MapFrom(src => src.EventStatus == null ? "" : src.EventStatus.Name))
                       .ForMember(dest => dest.EventVenueName, opt => opt.MapFrom(src => src.EventVenue == null ? "" : src.EventVenue.Name))
                       .ForMember(dest => dest.EventCategoryName, opt => opt.MapFrom(src => src.EventCategory == null ? "" : src.EventCategory.Name));
        }

        private void mappEventCategory()
        {
            CreateMap<EventCategoryDTO, EventCategoryEntity>()
                       .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.EventCategoryID))
                        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.EventCategoryName))
                       .ReverseMap();
        }

        private void mappEventAttendance()
        {
            CreateMap<EventAttendanceDTO, EventAttendanceEntity>()
                       .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.EventAttendanceID))
                       .ReverseMap()
                       .ForMember(dest => dest.EventDetailsName, opt => opt.MapFrom(src => src.EventDetails == null ? "" : src.EventDetails.Name))
                       .ForMember(dest => dest.UserAttendName, opt => opt.MapFrom(src => src.UserAttend == null ? "" : src.UserAttend.FullName));
        }   
    }
}
