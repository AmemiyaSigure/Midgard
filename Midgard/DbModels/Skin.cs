﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Midgard.Enumerates;

namespace Midgard.DbModels
{
    public class Skin
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public SkinModel Model { get; set; }
        
        [Required]
        public string Url { get; set; }
        
        public virtual User Owner { get; set; }
    }
}