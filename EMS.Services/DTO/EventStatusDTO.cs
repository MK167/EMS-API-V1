﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.Services.DTO
{
    public class EventStatusDTO
    {
        public Guid EventStatusID { get; set; }
        public bool IsDeleted { get; set; } = false;

        
        public String EventStatusName { get; set; }
    }
}
