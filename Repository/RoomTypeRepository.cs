using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private readonly FuminiHotelManagementContext _context;
        public RoomTypeRepository(FuminiHotelManagementContext context)
        {
            _context = context;
        }
        public void Add(RoomType roomType)
        {
            _context.RoomTypes.Add(roomType);
        }

        public IEnumerable<RoomType> GetAll()
        {
            return _context.RoomTypes.ToList();
        }

        public RoomType GetById(int roomTypeId)
        {
            return _context.RoomTypes.FirstOrDefault(r => r.RoomTypeId == roomTypeId);
        }

        public void Update(RoomType roomType)
        {
            var existingRoom = _context.RoomTypes.FirstOrDefault(r => r.RoomTypeId == roomType.RoomTypeId);
            if (existingRoom != null)
            {
                existingRoom.RoomTypeName = roomType.RoomTypeName;
                existingRoom.TypeDescription = roomType.TypeDescription;
                existingRoom.TypeNote = roomType.TypeNote;
                
                _context.SaveChanges();
            }
        }
    }
}
