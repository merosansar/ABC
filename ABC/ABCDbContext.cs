using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ABC.Models;
using ABC.ViewModels;

namespace ABC
{
    public class ABCDbContext:DbContext
    {
        public ABCDbContext() : base("ABCDBConnection") { }

        // Define DbSet properties for each of your model classes
        public DbSet<Question> Questions { get; set; }

        public DbSet<QuestionPaper> QuestionPaper { get; set; }
        public DbSet<GenerateQuestionPaperViewModel> GenerateQuestionPaperViewModel { get; set; }



        


        // Override OnModelCreating method to configure the model
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional model configuration can be done here
        }

        //[DbFunction("ABCDbContext", "GenerateRandomQuestionPaper")]
        //public virtual IEnumerable<QuestionPaper> GenerateRandomQuestionPaper(int NumberOfQuestions, string PaperTitle, string PaperDescription)
        //{
        //    throw new NotImplementedException();


        //}

    }
}