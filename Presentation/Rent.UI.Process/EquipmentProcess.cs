using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Web;
using Rent.Entities;
using System.Runtime.Serialization.Json;
using System.IO;


namespace Rent.UI.Process
{
    public class EquipmentProcess : ProcessComponent
    {
        public List<Equipment> All()
        {
            var response = HttpGet<List<Equipment>>("rest/Equipment/All", new Dictionary<string, object>(), "application/json");
            return response;
        }

        public void Add(Equipment equipmnet)
        {
            var request = HttpPost<Equipment>("rest/Equipment/Add", equipmnet, "application/json");
        }
    }
}
