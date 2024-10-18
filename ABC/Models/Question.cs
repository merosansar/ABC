using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ABC.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Marks { get; set; }

        [Required]
        [StringLength(70)]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [StringLength(70)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? ExamId { get; set; }

        public bool IsNepali { get; set; }

    }
}