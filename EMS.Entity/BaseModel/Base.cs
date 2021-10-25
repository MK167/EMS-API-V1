using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EMS.Entity.BaseModel
{
    public class Base
    {
        //identity key auto generated.

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime ActionDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime LatestUpdate { get; set; }
        public Int64 LatestUpdateUserID { get; set; }

        public Guid UserID { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}

