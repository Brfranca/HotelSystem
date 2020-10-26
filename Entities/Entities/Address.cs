﻿using Entities.DataAnnotations;
using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [TableName("EMPLOYEES")]
    public class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string CEP { get; set; }
    }
}