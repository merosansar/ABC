using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ABC.Models
{
    public class QuestionPaper
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? PaperId { get; set; }

        public int? QuestionId { get; set; }

        public int? SubjectId { get; set; }

        public int? TopicId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(255)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}