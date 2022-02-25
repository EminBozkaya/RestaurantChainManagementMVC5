using RCM.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCM.Model.Complex.DashBoard.SystemManagement.User
{
    public class AllAuthorityTypesForDropDownListVm
    {
        public byte id { get; set; }
        public List<AuthorityType> AuthorityTypes { get; set; }
    }
}
