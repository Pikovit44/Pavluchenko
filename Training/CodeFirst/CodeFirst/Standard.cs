﻿using System.Collections.Generic;

namespace CodeFirst
{
    public class Standard
    {
        public Standard()
        {

        }
        public int StandardId { get; set; }
        public string StandardName { get; set; }
            
        public ICollection<Student> Students { get; set; }
    }
}