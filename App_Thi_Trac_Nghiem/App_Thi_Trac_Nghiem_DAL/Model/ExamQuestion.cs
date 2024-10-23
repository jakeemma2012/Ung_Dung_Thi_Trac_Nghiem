namespace App_Thi_Trac_Nghiem_DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExamQuestion
    {
        public int ExamQuestionID { get; set; }

        public int? ExamID { get; set; }

        public int? QuestionID { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Question Question { get; set; }
    }
}
