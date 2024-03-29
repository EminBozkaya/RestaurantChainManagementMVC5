﻿using Core.Model;

namespace RCM.Model.Domain
{
    public class SaleNoteOfProduct : BaseDomain
    {
        public short PId { get; set; }
        public byte NoteId { get; set; }
        public bool IsActive { get; set; }

        public virtual Product Product { get; set; }
        public virtual SaleNote SaleNote { get; set; }
    }
}
