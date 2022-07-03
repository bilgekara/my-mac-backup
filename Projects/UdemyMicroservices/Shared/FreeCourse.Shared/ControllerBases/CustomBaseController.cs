using FreeCourse.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

// artık shared library bu frameworkun icersindeki tum kutuphaneler erisebilir

namespace FreeCourse.Shared.ControllerBases
{
    public class CustomBaseController : ControllerBase
	{
		public IActionResult CreateActionResultInstance<T>(Response<T> response)
        {
            /* ok, not found, created,..
             * her seferinde tek tek dönmek yerine 
             * return diyip bir object result donuyorum
             * object her seyı alabilir
             */
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };

        }
	}
}

