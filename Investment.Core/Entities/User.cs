using System.Collections.Generic;
using System.Linq;

namespace Investment.Core.Entities
{
    public class User : Entity
    {
        public User()
        {
            Wallet = new Wallet();
        }
        public string FirebaseId { get; set; }
        public string Name { get; set; }
        public Wallet Wallet { get; set; }
        public IEnumerable<UserActive> Actives { get; set; }

        public decimal GetSummarizedEquity()
        {
            return Wallet.Amount + (Actives.Sum(x => x.Quantity * x.Active.Amount));
        }
    }
}
