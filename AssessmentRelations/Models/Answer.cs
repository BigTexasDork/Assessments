using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssessmentRelations.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int AssessmentId { get; set; }
        public int Factor { get; set; }
        public string Comment { get; set; }
    }
}