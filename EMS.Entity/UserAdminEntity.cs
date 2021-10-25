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
        
        public String UserJobNumber { get; set; }

        
        public String FullName { get; set; }

        
        public String FirstName { get; set; }

        
        public String LastName { get; set; }

        public String Email { get; set; }

        public bool IsAdmin { get; set; } = false;


        public Guid JobID { get; set; }
        [ForeignKey("JobID")]
        public virtual JobEntity Job { get; set; }

        public Guid ImgPathID { get; set; }
        [ForeignKey("ImgPathID")]
        public virtual UserImageEntity UsrerImage { get; set; }
    }
}
