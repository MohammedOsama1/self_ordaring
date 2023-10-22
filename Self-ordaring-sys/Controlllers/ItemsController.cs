using Microsoft.AspNetCore.Mvc;
using Self.Core;
using Self.Core.Interfaces;
using Self_ordaring_sys.Models;

namespace Self_ordaring_sys.Controlllers
{

    [ApiController]
    public class ItemsController : ControllerBase
    {
       private readonly IUnitOfWorks _unitOfWorks;
        public ItemsController(IUnitOfWorks unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
            
        }
       
        [HttpGet("GetAllData")]
        public async Task<IActionResult> getAllData() {
            
           var rr =  await _unitOfWorks.ItemDetails.GetAllAsync();
            return Ok(rr);
        }

    }
}
