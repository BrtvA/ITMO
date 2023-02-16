using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADO.DBManager.AdoStudio.Models
{
    class LoginModel
    {
        public string? ServerName { get; set; }
        public string? DataBaseName { get; set; }
        public bool TrustedConnection { get; set; } = true;
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
