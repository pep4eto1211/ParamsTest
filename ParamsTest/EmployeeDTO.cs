﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsTest
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GroupDTO Parent { get; set; }
    }
}
