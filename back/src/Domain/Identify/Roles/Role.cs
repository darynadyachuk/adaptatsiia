using Domain.Identify.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Identify.Roles
{
    internal class Role
    {
        public RoleId RoleId { get; }
        public string Name { get; private set; }
        private Role(RoleId roleId, string name)
        {
            RoleId = roleId;
            Name = name;
        }
    }

}
