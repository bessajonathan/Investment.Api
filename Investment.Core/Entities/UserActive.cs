namespace Investment.Core.Entities
{
    public class UserActive:Entity
    {
        public UserActive()
        {

        }
        public UserActive(int userId,int activeId,int quantity)
        {
            UserId = userId;
            ActiveId = activeId;
            Quantity = quantity;
        }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ActiveId { get; set; }
        public Active Active { get; set; }
        public int Quantity { get;  set; }
    }
}
