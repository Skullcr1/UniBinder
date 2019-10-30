﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Linq;


namespace UniBinderAPI.Models
{
    [KnownType(typeof(Image))]
    [DataContract]
    public class Person
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public int HelpScore { get; set; }
        [DataMember]
        public int Likes { get; set; }
        [DataMember]
        public int Dislikes { get; set; }
        [DataMember]
        public int PeopleHelped { get; set; }
        [DataMember]
        public List<Subject> Subjects { get; set; }
        [DataMember]
        public string ImageByte { get; set; }

        public Person(int ID, string Name, string Password, string Email,
            int Age, int HelpScore, int Likes, int Dislikes, int PeopleHelped, List<Subject> Subjects)
        {
            this.ID = ID;
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.Age = Age;
            this.HelpScore = HelpScore;
            this.Likes = Likes;
            this.Dislikes = Dislikes;
            this.PeopleHelped = PeopleHelped;
            this.Subjects = Subjects;
        }

        public Person(int ID, string Name, string Password, string Email)
        {
            this.ID = ID;
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.Age = 0;
            this.HelpScore = 0;
            this.Likes = 0;
            this.Dislikes = 0;
            this.PeopleHelped = 0;
            this.Subjects = new List<Subject> { };
        }
        public int GetID(short ID)
        {
            int IntID = ID;
            return IntID;
        }



    }
}