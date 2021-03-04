using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace spletnaSPIV.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public WalletTbl FK_Wallet_Id { get; set; }
    }
}
