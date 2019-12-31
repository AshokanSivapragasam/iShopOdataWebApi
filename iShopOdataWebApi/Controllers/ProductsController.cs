using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.AspNet.OData.Query;

namespace iShopOdataWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public static PseudoModel pseudoModel { get; set; }
        public ProductsController()
        {
            if (pseudoModel == null)
            {
                var fileJsonText = System.IO.File.ReadAllText(@"products.json");
                pseudoModel = JsonConvert.DeserializeObject<PseudoModel>(fileJsonText, new JsonSerializerSettings
                {
                    CheckAdditionalContent = false,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Ignore,
                    MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                    ObjectCreationHandling = ObjectCreationHandling.Reuse
                });
            }
        }

        // GET api/products
        [HttpGet]
        [EnableQuery]
        public IQueryable<Product> Get()
        {
            return pseudoModel.products.DistinctBy(r => r.Title).AsQueryable();
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(string id)
        {
            return pseudoModel.products.Where(r => r.Id.Oid == id).FirstOrDefault();
        }

        // POST api/products
        [HttpPost]
        public void Post([FromBody] Product value)
        {
        }

        // PUT api/products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
        }

        // DELETE api/products/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
