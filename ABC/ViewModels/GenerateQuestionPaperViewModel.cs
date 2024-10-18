using ABC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ABC.ViewModels
{
    public class GenerateQuestionPaperViewModel

    {
       
        [Required(ErrorMessage = "Number of questions is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Number of questions must be greater than zero")]
        public int NumberOfQuestions { get; set; }

        [Required(ErrorMessage = "Paper title is required")]
        [StringLength(255, ErrorMessage = "Paper title cannot exceed 255 characters")]
        public string PaperTitle { get; set; }

        [Required(ErrorMessage = "Paper description is required")]
        public string PaperDescription { get; set; }

        //[Required(ErrorMessage = "Exam description is required")]
        public string ExamName { get; set; }
        public bool  IsNepali { get; set; }

        public List<QuestionPaper> QuestionPaperList { get; set; }


    }
}