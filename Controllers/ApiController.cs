using Microsoft.AspNetCore.Mvc;
using postgres_dotnet.EFCore;
using postgres_dotnet.Models;

namespace postgres_dotnet.Controllers
{
    [ApiController]
    public class ApiController : ControllerBase
    {

        private readonly DBHelper _db;
        public ApiController(EFDataContext efDataContext)
        {
            _db = new DBHelper(efDataContext);
        }



        // GET api/controller
        [HttpGet]
        [Route("api/[controller]/GetProducts")]
        public IActionResult Get()
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<ProductModel> data = _db.GetProducts();
                if (!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {


                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }



        // GET api/controller/5
        [HttpGet]
        [Route("api/[controller]/GetProduct/{id}")]
        public IActionResult Get(int id)
        {
            ResponseType type = ResponseType.Success;
            try
            {
                ProductModel data = _db.GetProductByID(id);
                if (data == null)
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {


                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // Post api/controller
        [HttpPost]
        [Route("api/[controller]/NewOrder/")]
        public IActionResult Post([FromBody] OrderModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveOrder(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch (Exception ex)
            {

                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // PUT api/controller/5
        [HttpPut]
        [Route("api/[controller]/EditOrder")]
        public IActionResult Put(int id, [FromBody] OrderModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveOrder(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch (Exception ex)
            {

                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // Delete api/controller/5
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.DeleteOrder(id);
                return Ok(ResponseHandler.GetAppResponse(type, "Deleted Successfully"));
            }
            catch (Exception ex)
            {

                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

    }
}