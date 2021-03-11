using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace spletnaSPIV.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public Currency Currency { get; set; }

        public virtual Wallet Sender { get; set; }
        public virtual Wallet Reciever { get; set; }

        public string Name { get; set; }
    }
}
