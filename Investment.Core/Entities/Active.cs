using Investment.Core.Enums;

namespace Investment.Core.Entities
{
    public class Active:Entity
    {
        public Active(decimal amount, EUserActiveType activeType)
        {
            Amount = amount;
            ActiveType = activeType;
        }
        public decimal Amount { get; private set; }
        public EUserActiveType ActiveType { get; private set; }
    }
}
