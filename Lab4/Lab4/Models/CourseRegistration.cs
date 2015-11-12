namespace Lab4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CourseRegistration")]
    public partial class CourseRegistration
    {
        public int CourseRegistrationID { get; set; }

        public int? CourseID { get; set; }

        public int? StudentID { get; set; }

        public int? Grade { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}
