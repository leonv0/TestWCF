namespace ImportService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Passenger")]
    public partial class Passenger
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long Flight_ID { get; set; }

        [StringLength(128)]
        public string Name { get; set; }

        [StringLength(14)]
        public string Reservation_Number { get; set; }

        [StringLength(36)]
        public string DocumentNumber { get; set; }

        public virtual Flight Flight { get; set; }
    }
}
