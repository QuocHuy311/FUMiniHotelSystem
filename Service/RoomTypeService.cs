﻿using BusinessObjects.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RoomTypeService(RoomTypeRepository roomTypeRepo)
    {
        private readonly RoomTypeRepository _roomTypeRepo = roomTypeRepo;

        public IEnumerable<RoomType> GetAllTypes()
        {
            IEnumerable<RoomType> roomTypes = _roomTypeRepo.GetAll();
            return roomTypes;
        }

        public void AddRoomType(RoomType roomType)
        {
            _roomTypeRepo.Add(roomType);
        }

        public RoomType GetRoomTypeById(int id)
        {
            return _roomTypeRepo.GetById(id);
        }

        public void UpdateRoom(RoomType roomType)
        {
            _roomTypeRepo.Update(roomType);
        }
    }
}
