﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Models
{
    public class City
    {
        public City()
        {
            Photos = new List<Photo>(); // şehirlerin fotoğrafları var 
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }        
        public int UserId { get; set; }
        public List<Photo> Photos { get; set; }
        public User User { get; set; } //şehirlerin ekleyeni yani kullanıcısı var

    }
}
