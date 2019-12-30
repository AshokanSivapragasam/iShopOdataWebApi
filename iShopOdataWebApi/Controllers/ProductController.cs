using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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
        public ActionResult<IEnumerable<DataModel>> Get()
        {
            return pseudoModel.dataModels.ToList();
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public ActionResult<DataModel> Get(int id)
        {
            return default(DataModel);
        }

        // POST api/products
        [HttpPost]
        public void Post([FromBody] DataModel value)
        {
        }

        // PUT api/products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DataModel value)
        {
        }

        // DELETE api/products/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
