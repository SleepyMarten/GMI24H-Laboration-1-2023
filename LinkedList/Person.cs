﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public Guid id { get; set; }
        public string occupation { get; set; }

        public Person(string name, int age,string occupation)
        {
            this.name = name;
            this.age = age;
            this.id = Guid.NewGuid();
            this.occupation = occupation;
        }
        /// <summary>
        /// method to return name of person
        /// </summary>
        /// <returns>name</returns>
        public string getName()
        {
            return name;
        }
        /// <summary>
        /// Method to return all variables in Person
        /// </summary>
        /// <returns>name, age, id, occupation</returns>
        public string getAll()
        {
            return ($"Name: {name} Age: {age} ID: {id} Occupation: {occupation}");
        }
    }
}
