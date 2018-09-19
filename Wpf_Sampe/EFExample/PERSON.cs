namespace EFExample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PERSON")]
    public partial class PERSON
    {
        public int ID { get; set; }

        public string VORNAME { get; set; }

        public string NACHNAME { get; set; }

        public int? ID_ADDRESS { get; set; }

        public virtual ADDRESS ADDRESS { get; set; }
    }
}
