using HW5.Interfaces;
using HW5.Models;
using HW5.Reposiitories;

namespace HW5.Services
{
    public class FriendService : IFriendService
    {
        private FriendRepository _friendRepository = new FriendRepository();
        public List<Friend> GetAll() { return _friendRepository.FriendsGet(); }
        public Friend Get(int friendId) { return _friendRepository.FriendGet(friendId); }
        public void Save(Friend friend) { _friendRepository.FriendsAdd(friend); }
        public void Delete(int friendId) { _friendRepository.FriendsDelete(friendId); }
        public void Update(Friend friend) { _friendRepository.FriendsUpdate(friend); }
    }
}
