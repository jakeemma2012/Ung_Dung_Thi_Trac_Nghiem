namespace App_Thi_Trac_Nghiem_DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Attempt
    {
        public int AttemptID { get; set; }

        public int? ExamID { get; set; }

        public int? UserID { get; set; }

        public DateTime? AttemptDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        public virtual Account Account { get; set; }

        public virtual Exam Exam { get; set; }
    }
}
