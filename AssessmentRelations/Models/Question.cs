using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssessmentRelations.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public int ParentQuestionId { get; set; }
        public string Number { get; set; }
    }
}