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

        [StringLength(250)]
        public string JobName { get; set; }

        public Guid ImgPathID { get; set; }

        [StringLength(900)]
        public string ImgPathName { get; set; }


    }
}
