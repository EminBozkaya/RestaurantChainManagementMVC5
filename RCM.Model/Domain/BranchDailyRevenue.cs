﻿using Core.Model;
using System;

namespace RCM.Model.Domain
{
    public class BranchDailyRevenue : BaseDomain
    {
        public int Id { get; set; }
        public short BId { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<decimal> Amount { get; set; }

        public virtual Branch Branch { get; set; }
    }
}
