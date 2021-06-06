using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SyncfusionBlazorServerWithAuthCore3.Data;
using System.Text.Json;
namespace SyncfusionBlazorServerWithAuthCore3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GridController : ControllerBase
    {
        private readonly DataGridService DataGridService;
        public GridController(DataGridService dataGridService)
        {
            DataGridService = dataGridService;
        }
        [HttpGet]
        public async Task<string> Get()
        {
            var EventDetails = new List<EventDetails>();
            EventDetails = await Task.FromResult(DataGridService.GetEvent());
            return JsonSerializer.Serialize(EventDetails);
        }
    }
}
