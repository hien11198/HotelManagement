using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HotelManagement.DTO
{
    public class ReceiveRoomDetails
    {
        private int idReceiveRoom;
        private int idCustomerOther;
        public ReceiveRoomDetails(DataRow row)
        {
            IdReceiveRoom = (int)row["idReceiveRoom"];
            IdCustomerOther = (int)row["idCustomerOther"];
        }
        public int IdReceiveRoom { get => idReceiveRoom; set => idReceiveRoom = value; }
        public int IdCustomerOther { get => idCustomerOther; set => idCustomerOther = value; }
    }
}
