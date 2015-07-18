﻿using System;
using System.ComponentModel.DataAnnotations;
namespace UniRitter.UniRitter2015.Models
{
    public class CommentModel
    {
        public Guid? id { get; set; }

        [MaxLength(1000)]
        [Required]
        public string body { get; set; }

        [MaxLength(50)]
        [Required]
        public string title { get; set; }

        public PersonModel author { get; set; }

    }
}