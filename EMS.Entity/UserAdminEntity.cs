using EMS.Entity.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EMS.Entity
{
    public class UserAdminEntity : Base
    {
        [StringLength(250)]
        public string UserJobNumber { get; set; }

        [StringLength(250)]
        public string FullName { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        [StringLength(550)]
        public string Email { get; set; }

        public bool IsAdmin { get; set; } = false;


        public Guid JobID { get; set; }
        [ForeignKey("JobID")]
        public virtual JobEntity Job { get; set; }

        public Guid ImgPathID { get; set; }
        [ForeignKey("ImgPathID")]
        public virtual UserImageEntity UsrerImage { get; set; }
    }
}
