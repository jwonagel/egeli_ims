namespace EFExample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADDRESS")]
    public partial class ADDRESS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADDRESS()
        {
            PERSON = new HashSet<PERSON>();
        }

        public int ID { get; set; }

        [StringLength(128)]
        public string STREET { get; set; }

        [StringLength(128)]
        public string HOUSENUMBER { get; set; }

        [StringLength(128)]
        public string ZIP { get; set; }

        [StringLength(128)]
        public string CITY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSON> PERSON { get; set; }
    }
}
