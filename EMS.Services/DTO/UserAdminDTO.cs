using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Services.DTO
{
    public class UserAdminDTO
    {
        public Guid UserAdminID { get; set; }
        public bool IsDeleted { get; set; } = false;

        public String UserJobNumber { get; set; }
        
        public String FullName { get; set; }
        
        public String FirstName { get; set; }
        
        public String LastName { get; set; }
        
        public String Email { get; set; }

        public bool IsAdmin { get; set; } = false;

        public Guid JobID { get; set; }

        public String JobName { get; set; }

        public Guid ImgPathID { get; set; }
        
        public String ImgPathName { get; set; }


    }
}
