using AuthenticatedAPIN.Database;
using AuthLibrary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticatedAPIN.Controllers;
[Authorize]
[ApiController]
[Route("[controller]/[action]")]
public class itemController : ControllerBase
{
    private readonly databaseContext _DbContext;

    public itemController(ILogger<itemController> logger, databaseContext DbContext)
    {
        _DbContext = DbContext;
    }
[HttpGet]
public IActionResult GetAllitems()
{
    return Ok(_DbContext.items);
}
[HttpGet]
public IActionResult GetitemsByCategory(int categoryId)
{
    var itemsInCategory = _DbContext.items.Where(p => p.itemCategory.Id == categoryId).ToList();
    return Ok(itemsInCategory);
}
[HttpPost]
public IActionResult Additem(Item item){
    if(item == null)
    {
        return BadRequest();
    }
    _DbContext.items.Add(item);
    _DbContext.SaveChanges();
    return Ok(item);
}
}