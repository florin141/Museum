﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Core.Domain
{
    public class Feature : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Museums> Museums { get; set; }
    }
}
