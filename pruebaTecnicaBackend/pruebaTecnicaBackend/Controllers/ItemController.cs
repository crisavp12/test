using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using pruebaTecnicaBackend.Models;

namespace pruebaTecnicaBackend.Controllers
{

    public class ItemController : ApiController
    {

        // GET api/<controller>/5
        [Route("getItem/{type}")]
        [HttpGet]
        public List<Item> GetItem(int type = 0)
        {
            return DBConnection.StoreProcediur.GetItem(type);
        }

        [Route("storageItem")]
        [HttpPost]
        public bool createItem([FromBody] Item item)
        {
            return DBConnection.StoreProcediur.StorageItem(item);
        }

        [Route("itemOutput/{id}")]
        [HttpGet]
        public bool ItemOutput(int id)
        {
            return DBConnection.StoreProcediur.ItemOutput(id);
        }

        [Route("changeStatus/{id}")]
        [HttpGet]
        public bool ChangeStatus(int id)
        {
            return DBConnection.StoreProcediur.ChangeStatus(id);
        }
    }
}