﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVCProject.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAd { get; set; }
        public List<Makale> Makaleler { get; set; } 
    }
}