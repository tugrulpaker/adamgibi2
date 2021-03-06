﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using adamgibi2.Controllers;

namespace adamgibi2.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }

     
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
