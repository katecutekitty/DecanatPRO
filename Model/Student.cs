﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student : IDomainObject
    {
        public string Name { get; set; }

        public string Speciality {  get; set; }

        public string Group { get; set; }

        public int Id { get; set; }
    }
}
