﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC_Example1.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        [DisplayName("TA LastName")]
        public string LastName { get; set; }
        public int SoonerId { get; set; }


    }
}