﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class Person
    {
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public Person(int age, string phoneNumber)
        {
            Age = age;
            PhoneNumber = phoneNumber;
        }
    }
}
