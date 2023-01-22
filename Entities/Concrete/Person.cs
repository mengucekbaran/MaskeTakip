﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entities , veri tabanı nesnelerini ve diğer nesneleri tutacak olan katmandır.
namespace Entities.Concrete
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}
