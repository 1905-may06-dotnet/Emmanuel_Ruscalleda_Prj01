using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class UserAccess
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual UserName EmailNavigation { get; set; }
    }
}
