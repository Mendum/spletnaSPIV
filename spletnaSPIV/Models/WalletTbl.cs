using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spletnaSPIV.Models
{
    public class WalletTbl
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public int FK_Wallet_Id { get; set; }
    }
}
