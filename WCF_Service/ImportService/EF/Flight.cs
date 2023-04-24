namespace ImportService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flight")]
    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            Passengers = new HashSet<Passenger>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public int Flight_Number_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Flight_Date { get; set; }

        public DateTime? Estimate_Arrival { get; set; }

        public DateTime? Arrival { get; set; }

        public virtual Flight_Number Flight_Number { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passenger> Passengers { get; set; }
    }
}
