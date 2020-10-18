using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCore3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCore3.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "GET";
        }

        [HttpGet]
        [Route("{id:int}")]
        public string GetById(int id)
        {
            return "GET Id";
        }


        [HttpPost]
        public Category Post([FromBody] Category model)
        {
            return model;
        }

        [HttpPut]
        [Route("{id:int}")]

        public Category Put(int id, [FromBody] Category model)
        {
            if (model.Id == id)
            {
                return model;
            }

            return null;
        }

        [HttpDelete]
        [Route("{id:int}")]

        public Category Delete(int id, [FromBody] Category model)
        {
            if (model.Id == id)
            {
                return model;
            }

            return null;

        }
    }
}
