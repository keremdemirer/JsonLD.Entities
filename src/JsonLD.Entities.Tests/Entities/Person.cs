﻿using System;

namespace JsonLD.Entities.Tests.Entities
{
    public class Person
    {
        public Uri Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
