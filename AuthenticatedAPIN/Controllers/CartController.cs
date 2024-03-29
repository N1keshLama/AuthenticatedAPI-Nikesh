using AuthenticatedAPIN.Data;
using AuthLibrary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore; // If not already added

namespace AuthenticatedAPIN.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]/[action]")]
    public class CartController : ControllerBase
    {
        private readonly databaseContext _DbContext;

        public CartController(ILogger<CartController> logger, databaseContext DbContext)
        {
            _DbContext = DbContext;
        }

        [HttpGet]
        public async Task<List<ItemModel>?> GetUserItem()
        {
            var user = User.Identity?.Name ?? string.Empty;
            var cart = await _DbContext.ShoppingCart.Where(ShopCart => ShopCart.User == user).FirstOrDefaultAsync();
            return cart?.ItemList;
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUserItem(int id)
        {
            var user = User.Identity?.Name ?? string.Empty;
            var cart = await _DbContext.ShoppingCart.Where(ShopCart => ShopCart.User == user).FirstOrDefaultAsync();
            cart?.ItemList.RemoveAll(item => item.Id == id);
            await _DbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserItem(int id)
        {
            var user = User.Identity?.Name ?? string.Empty;
            var cart = await _DbContext.ShoppingCart.Where(ShopCart => ShopCart.User == user).FirstOrDefaultAsync();

            if (cart is null)
            {
                _DbContext.Add(new ShoppingCart()
                {
                    User = user,
                    ItemList = new List<ItemModel> { new ItemModel { Id = id } }
                });
            }
            else
            {
                cart.ItemList.Add(new ItemModel() { Id = id });
            }

            await _DbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
