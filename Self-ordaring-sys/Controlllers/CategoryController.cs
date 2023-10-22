using Microsoft.AspNetCore.Mvc;
using Self.Core;

namespace Self_ordaring_sys.Controlllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWorks _unitOfWorks;

        public CategoryController(IUnitOfWorks unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
        }

        [HttpGet("GetAllCats")]
        public async Task <IActionResult> allCategory() 
        {
          var dd =  await _unitOfWorks.Categories.GetAllAsync();
            return Ok(dd);
        }

    }
}
