using IMS_API.Data;
using IMS_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace IMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    // ITEM CONTROLLER
    public class ItemController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public ItemController(DataContext dataContext) => _dataContext = dataContext;
        [HttpGet]
        public async Task<IEnumerable<Item>> GetItems()
        {
            return await _dataContext.Items.ToListAsync();
        }
    }
}
