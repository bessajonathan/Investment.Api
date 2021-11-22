namespace Investment.Core.Entities
{
    public class Wallet:Entity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public decimal Amount { get; set; }
    }
}
