using EMS.Entity.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EMS.Entity
{
    public class UserAttendEntity : Base
    {
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
        [ForeignKey("UniversityID")]
        public virtual UniversityEntity University { get; set; }

        public Guid UserTypeID { get; set; }
        [ForeignKey("UserTypeID")]
        public virtual UserTypeEntity UserType { get; set; }

        public Guid NationalityID { get; set; }
        [ForeignKey("NationalityID")]
        public virtual NationalityEntity Nationality { get; set; }

        public Guid GenderID { get; set; }
        [ForeignKey("GenderID")]
        public virtual GenderEntity Gender { get; set; }


        public virtual ICollection<EventAttendanceEntity> EventAttendances { get; set; }

    }
}
