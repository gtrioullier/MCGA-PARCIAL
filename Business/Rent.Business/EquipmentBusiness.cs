using Rent.Data;
using Rent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Business
{
    public class EquipmentBusiness
    {
        public List<Equipment> All()
        {
            var EquipmentDAC = new EquipmentDAC();
            return EquipmentDAC.Select();
        }

        public Equipment Add(Equipment equipment)
        {
            var EquipmentDAC = new EquipmentDAC();
            return EquipmentDAC.Create(equipment);
        }
    }
}
