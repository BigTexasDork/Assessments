﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssessmentRelations.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}