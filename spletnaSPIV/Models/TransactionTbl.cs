using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace spletnaSPIV.Models
{
    public class TransactionTbl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public UserTbl Sender { get; set; }
        public UserTbl Receiver { get; set; }
        public WalletTbl FK_Wallet_Id { get; set; }
    }
}
