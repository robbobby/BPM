using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace BPMWebApi.Controllers {
    public class LoginController : ControllerBase {
        
        public IActionResult Authenticate() {
            return RedirectToAction("");
        }
    }
}
