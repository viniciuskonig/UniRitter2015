﻿using System;
using System.ComponentModel.DataAnnotations;
namespace UniRitter.UniRitter2015.Models
{
    public class PostModel
    {
        public Guid? id { get; set; }

        [MaxLength(4000)]
        [Required]
        public string body {get;set;}

        [MaxLength(100)]
        [Required]
        public string title {get;set;}
        
        public PersonModel author {get;set;}

        public string[] tags {get; set;}

    }
}