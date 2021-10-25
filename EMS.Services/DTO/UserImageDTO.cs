using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Services.DTO
{
    public class UserImageDTO
    {
        public Guid UserImageID { get; set; }
        public bool IsDeleted { get; set; } = false;

        [StringLength(900)]
        public string ImgPathName { get; set; }
    }
}
