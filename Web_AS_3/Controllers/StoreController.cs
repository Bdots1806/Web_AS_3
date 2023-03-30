using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_AS_3.Models;

namespace Web_AS_3.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly ProductContext _dbContext;

        public StoreController(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            if(_dbContext.Users == null)
            {
                return NotFound();
            }
            return await _dbContext.Users.ToListAsync();

        }
        [HttpGet]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            if (_dbContext.Users == null)
            {
                return NotFound();
            }
            var user = await _dbContext.Users.FindAsync(id);
            if(user == null) { 
                return NotFound();
            }
            return user;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cart>>> GetCarts()
        {
            if (_dbContext.Carts == null)
            {
                return NotFound();
            }
            return await _dbContext.Carts.ToListAsync();

        }
        [HttpGet]
        public async Task<ActionResult<Cart>> GetCart(int id)
        {
            if (_dbContext.Carts == null)
            {
                return NotFound();
            }
            var cart = await _dbContext.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            return cart;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comments>>> GetComments()
        {
            if (_dbContext.Carts == null)
            {
                return NotFound();
            }
            return await _dbContext.Comments.ToListAsync();

        }
        [HttpGet]
        public async Task<ActionResult<Comments>> GetComment(int id)
        {
            if (_dbContext.Comments == null)
            {
                return NotFound();
            }
            var com = await _dbContext.Comments.FindAsync(id);
            if (com == null)
            {
                return NotFound();
            }
            return com;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            if (_dbContext.Carts == null)
            {
                return NotFound();
            }
            return await _dbContext.Products.ToListAsync();

        }
        [HttpGet]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            if (_dbContext.Products == null)
            {
                return NotFound();
            }
            var product = await _dbContext.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUsers), new { id = user.UserId}, user);
        }
        [HttpPost]
        public async Task<ActionResult<Cart>> PostCart(Cart cart)
        {
            _dbContext.Carts.Add(cart);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCarts), new { id = cart.cartId }, cart);
        }
        [HttpPost]
        public async Task<ActionResult<Comments>> PostComment(Comments comments)
        {
            _dbContext.Comments.Add(comments);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetComments), new { id = comments.CommentsId }, comments);
        }
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProducts), new { id = product.ProductID }, product);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteDUser(int id)
        {
            var user = await _dbContext.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteDProduct(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();

            return product;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Comments>> DeleteDComment(int id)
        {
            var comment = await _dbContext.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }

            _dbContext.Comments.Remove(comment);
            await _dbContext.SaveChangesAsync();

            return comment;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cart>> DeleteDCart(int id)
        {
            var cart = await _dbContext.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }

            _dbContext.Carts.Remove(cart);
            await _dbContext.SaveChangesAsync();

            return cart;
        }
    }
}
