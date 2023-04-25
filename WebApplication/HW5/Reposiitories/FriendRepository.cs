using HW5.Add_Data;
using HW5.Models;
using System.Numerics;

namespace HW5.Reposiitories
{
    public class FriendRepository
    {
        private JSONDb _db;
        public FriendRepository() { _db = new JSONDb(); }
        public bool IsUniqueId(int id)
        {
            return FriendGet(id) == null ? true  : false;
        }
        public List<Friend> FriendsGet()
        {
            return _db.DbRoot.Friends.OrderBy(x => x.FriendID).ToList();
        }
        public void FriendsAdd(Friend friend)
        {
            _db.DbRoot.Friends.Add(friend);
            _db.Save();
        }
        public void FriendsDelete(int friendId)
        {
            _db.DbRoot.Friends.Remove(FriendGet(friendId));
            _db.Save();
        }
        public Friend FriendGet(int friendId) 
        { 
            return _db.DbRoot.Friends.FirstOrDefault(f => f.FriendID == friendId); 
        }

        public void FriendsUpdate(Friend friend)
        {
            FriendsDelete(friend.FriendID);
            FriendsAdd(friend);
            _db.Save();
        }
    }    
}
