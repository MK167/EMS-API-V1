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

        [StringLength(300)]
        public string Title { get; set; }

        [StringLength(550)]
        public string FullName { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        [StringLength(550)]
        public string Email { get; set; }

        [StringLength(550)]
        public string Address { get; set; }

        public bool IsVIP { get; set; } = false;



        public Guid UniversityID { get; set; }
        [StringLength(250)]
        public string UniversityName { get; set; }



        public Guid UserTypeID { get; set; }
        [StringLength(250)]
        public string UserTypeName { get; set; }



        public Guid NationalityID { get; set; }
        [StringLength(250)]
        public string NationalityName { get; set; }



        public Guid GenderID { get; set; }
        [StringLength(250)]
        public string GenderName { get; set; }
    }
}
