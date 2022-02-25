using RCM.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCM.Model.Complex.DashBoard.SystemManagement.User
{
    public class AllBranchesForDropDownListVm
    {
        public int id { get; set; }
        public List<Branch> Branches { get; set; }
    }
}
