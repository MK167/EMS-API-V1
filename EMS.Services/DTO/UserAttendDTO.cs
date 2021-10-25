using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Services.DTO
{
    public class UserAttendDTO
    {
        public Guid UserAttendID { get; set; }
        public bool IsDeleted { get; set; } = false;

        public String Title { get; set; }

        public String FullName { get; set; }

        public String FirstName { get; set; }
        
        public String LastName { get; set; }

        public String Email { get; set; }
        
        public String Address { get; set; }

        public bool IsVIP { get; set; } = false;


        public Guid UniversityID { get; set; }
        
        public String UniversityName { get; set; }

        public Guid UserTypeID { get; set; }
        
        public String UserTypeName { get; set; }


        public Guid NationalityID { get; set; }
        
        public String NationalityName { get; set; }


        public Guid GenderID { get; set; }
        
        public String GenderName { get; set; }
    }
}
