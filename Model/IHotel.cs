using System.Collections.Generic;

namespace Model
{
    public interface IHotel
    {
        List<IRoom> GetRooms();
        void SetRooms();
        void AddRoom();
    }
}