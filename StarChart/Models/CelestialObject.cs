﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int Id;
        [Required]
        public string Name;

    }
}
