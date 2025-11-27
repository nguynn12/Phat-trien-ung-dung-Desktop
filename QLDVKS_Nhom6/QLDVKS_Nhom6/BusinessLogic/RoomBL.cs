using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RoomBL
    {
        RoomDA roomDA = new RoomDA();

        public List<Room> GetAll()
        {
            return roomDA.GetAll();
        }

        public int Insert(Room room)
        {
            return roomDA.Insert_Update_Delete(room, 0); // 0 = Insert
        }

        public int Update(Room room)
        {
            return roomDA.Insert_Update_Delete(room, 1); // 1 = Update
        }

        public int Delete(Room room)
        {
            return roomDA.Insert_Update_Delete(room, 2); // 2 = Delete
        }
    }
}
