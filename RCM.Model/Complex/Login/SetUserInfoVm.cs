using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCM.Model.Complex.Login
{
    public class SetUserInfoVm
    {
        public short activeBranchId { get; set; }
        public byte activeAuthrtyTypID { get; set; }
        public string activeBranchName { get; set; }
    }
}
