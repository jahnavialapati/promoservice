using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PromoServiceMongoDB.Model;
using PromoServiceMongoDB.DataAccess;
using PromoServiceMongoDB.DataAccess.Utility;
//using Microsoft.AspNetCore.Mvc;

namespace PromoServiceMongoDB.Controllers
{

    [Route("/v1/promotions")]
    [ApiController]
    public class CosmosController : ControllerBase
    {
        ICosmosDataAdapter _adapter;




        /* public CosmosController()
         {
         }*/

        public CosmosController(ICosmosDataAdapter adapter)
        {
            _adapter = adapter;
        }

        /*  [HttpGet]
          public async Task<IActionResult> Get()
          {


              var result = await _adapter.Get();
              return Ok(result);
          }
  */

        /*  [HttpPost]
          public async Task<IActionResult> CreateDocument([FromBody] ProductPromo productpromo)
          {

             *//* CosmosController cosmocontroller = new CosmosController();
              CosmosDataAdapter.ge*//*

             var result =  await _adapter.CreateDocument("PromoService", "ProductPromo", productpromo);

             //return new JsonResult(productpromo);
              return Ok(result);
          }*/

        [HttpPost]
        [Route("action")]
        public async Task<IActionResult> CreateAction([FromBody] ProductPromoAction productpromoaction)
        {

            var result = await _adapter.CreateAction("PromoDatabase", "ProductPromoAction", productpromoaction);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDocument([FromBody] ProductPromo productpromo)
        {
            var result = await _adapter.CreateDocument("PromoDatabase", "ProductPromo", productpromo);
            return Ok(result);
        }

        [HttpPut]
        [Route("id/action")]
        public async Task<IActionResult> UpdateAction([FromBody] ProductPromoAction productpromoaction)
        {
            var result = await _adapter.updateDocumentAsyncAction("PromoDatabase", "ProductPromoAction", productpromoaction);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _adapter.DeleteUserAsync("PromoDatabase", "ProductPromo", id);
            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _adapter.GetDataAsync("PromoDatabase", "ProductPromo");
            return Ok(result);
        }

       /* [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var result = await _adapter.GetBy("PromoDatabase", "ProductPromo",id);
            return Ok(result);
        }*/

       /* [HttpPut]
        public async Task<IActionResult> Update([FromBody] ProductPromo productpromo)
        {
            var result = await _adapter.updateDocumentAsync("PromoDatabase", "ProductPromo", productpromo);
            return Ok(result);
        }
*/
        /* [HttpGet("{id}")]
         public async Task<ActionResult> GetBy(long id)
         {
             var result = await _adapter.FindAsync(id);

             if (result == null)
             {
                 return NotFound();
             }

             return result;
         }*/


    }
}
