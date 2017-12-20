﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Toys
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Nullable<long> Size { get; set; }
        public string Owner { get; set; }
    }
}
