﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class StudentSubject
    {
        [Key]
        public int StudSubID { get; set; }
        public int StudID { get; set; }
        public int SubID { get; set; }
        [ForeignKey("StudID")]
        public virtual Student Student { get; set; }
        [ForeignKey("StuSubIDdID")]
        public virtual Subjects Subject { get; set; }
    }
}
