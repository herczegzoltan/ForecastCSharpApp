﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp.Models
{
    public class RootObject
    {
        public Currently currently { get; set; }
        public DailyModel daily { get; set; }
    }
}
