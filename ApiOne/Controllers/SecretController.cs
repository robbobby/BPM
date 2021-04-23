using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace ApiOne.Controllers {
    public class SecretController : Controller {
        
        [Route("/secret")]
        [Authorize]
        public OkResult Index() {
            return Ok();
        }
    }
}
