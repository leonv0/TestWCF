namespace ImportService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Registration")]
    public partial class Registration
    {
        public long ID { get; set; }

        public long? Session_ID { get; set; }

        [StringLength(128)]
        public string First_Name { get; set; }

        [StringLength(128)]
        public string Last_Name { get; set; }

        [Required]
        [StringLength(128)]
        public string Flight_Number { get; set; }

        [Required]
        [StringLength(128)]
        public string Flight_Time { get; set; }

        public short? Laggage_Count { get; set; }

        public virtual Session Session { get; set; }
    }
}
