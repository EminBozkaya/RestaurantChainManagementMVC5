﻿using Core.Model;
using System.Collections.Generic;

namespace RCM.Model.Domain
{
    public class PositionType : BaseDomain
    {
        public PositionType()
        {
            this.Employees = new HashSet<Employee>();
        }

        public byte Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
