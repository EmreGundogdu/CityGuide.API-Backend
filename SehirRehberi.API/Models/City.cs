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
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Descriptiom { get; set; }

        public List<Photo> Photos { get; set; }
        public List<User> User { get; set; } //şehirlerin ekleyeni yani kullanıcısı var

    }
}
