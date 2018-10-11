using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace test1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanksController: ControllerBase
    {
        private readonly PortalDbContext _portalDbContext;

        public BanksController(PortalDbContext portalDbContext)
        {
            this._portalDbContext = portalDbContext;
        }

        [HttpGet]
        public ActionResult<List<Bank>> Get()
        {
            return _portalDbContext.GetAllBanks();
        }
    }
}
