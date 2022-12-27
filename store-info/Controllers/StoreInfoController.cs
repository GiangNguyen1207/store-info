using Microsoft.AspNetCore.Mvc;
using store_info.Models;

namespace store_info.Controllers;

[Route("store")]
[ApiController]
public class StoreInfoController : Controller
{
    private readonly StoreInfoContext _storeInfoContext;

    public StoreInfoController(StoreInfoContext storeInfoContext)
    {
        _storeInfoContext = storeInfoContext;
    }
    
    [HttpGet]
    public IActionResult GetAll()
    {
        var result = _storeInfoContext.StoreInfos.Select(info => info.StoreName);
        return Ok(result);
    }
}