using Rent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Rent.Business;
using System.Net.Http;
using System.Net;

namespace Rent.Services.Http
{
    [RoutePrefix("rest/Equipment")]
    public class EquipmentService : ApiController
    {
        [Route("All")]
        [HttpGet]
        public List<Equipment> All()
        {
            try
            {
                var response = new List<Equipment>();
                var equipmentBussines = new EquipmentBusiness();
                response = equipmentBussines.All();
                return response;
            }
            catch (Exception ex)
            {
                var httperror = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httperror);
            }
        }

        [Route("Add")]
        [HttpPost]
        public Equipment Add(Equipment equipment)
        {
            try
            {
                var equipmentBusiness = new EquipmentBusiness();
                return equipmentBusiness.Add(equipment);
            }
            catch (Exception ex)
            {
                var httperror = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httperror);
            }

        }

    }
}
