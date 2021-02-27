using Microsoft.AspNetCore.Mvc;
using ShowcaseWeb.Domain.Models;
using ShowcaseWeb.Domain;
using System.Collections.Generic;

namespace ShowcaseWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowcaseController : ControllerBase
    {
        private readonly IShowcaseService showcaseService;

        public ShowcaseController(IShowcaseService showcaseService)
        {
            this.showcaseService = showcaseService;
        }

        [HttpPost]
        public ActionResult<bool> Add(Showcase showcase)
        {
            return Ok(showcaseService.Add(showcase));
        }

        [HttpGet]
        public ActionResult<List<Showcase>> Get()
        {
            return showcaseService.Get();
        }

        [HttpGet]
        public ActionResult<Showcase> Get(int showcaseId)
        {
            return showcaseService.Get(showcaseId);
        }
    }
}
