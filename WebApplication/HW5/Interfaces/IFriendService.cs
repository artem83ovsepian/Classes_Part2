using HW5.Models;

namespace HW5.Interfaces
{
    public interface IFriendService
    {
        public List<Friend> GetAll();
        public Friend Get(int id);
        public void Save(Friend friend);
        public void Delete(int FriendId);
        public void Update(Friend friend);
        
    }
}
