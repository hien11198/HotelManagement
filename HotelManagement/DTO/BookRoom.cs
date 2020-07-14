using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HotelManagement.DTO
{
    public class BookRoom
    {
        private int id;
        private int idCustomer;
        private int idRoomType;
        private DateTime dateCheckIn;
        private DateTime dateCheckOut;
        private DateTime dateBookRoom;

        public BookRoom(int id,int idCustomer,int idRoomType,DateTime dateCheckIn,DateTime dateCheckOut,DateTime dateBookRoom)
        {
            this.Id = id;
            this.IdCustomer = idCustomer;
            this.IdRoomType = idRoomType;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.DateBookRoom = dateBookRoom;
        }
        public BookRoom(DataRow row)
        {
            Id = (int)row["id"];
            IdCustomer = (int)row["idCustomer"];
            IdRoomType = (int)row["idRoomType"];
            DateCheckIn = (DateTime)row["dateCheckIn"];
            DateCheckOut = (DateTime)row["dateChekOut"];
            DateBookRoom = (DateTime)row["dateBookRoom"];
        }
        public int Id { get => id; set => id = value; }
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
        public int IdRoomType { get => idRoomType; set => idRoomType = value; }
        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public DateTime DateBookRoom { get => dateBookRoom; set => dateBookRoom = value; }
    }
}
