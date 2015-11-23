using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssessmentRelations.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public int ClientId { get; set; }
        public int ProjectId { get; set; }
        public string AsssessmentType { get; set; }
    }
}