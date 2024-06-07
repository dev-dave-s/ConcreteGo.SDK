﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.SDK.Models.Divisions
{
    public class DivisionRequestOptions
    {
        public List<int>? IDs { get; set; }
        public List<string>? Codes { get; set; }
        public List<string>? Names { get; set; }
        public List<string>? IncludeRetElements { get; set; }
    }
}
