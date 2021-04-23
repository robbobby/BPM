using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;
namespace ApiTwo.Controllers {
    public class HomeController : Controller {
        private IHttpClientFactory _clientFactory;
        
        public HomeController(IHttpClientFactory clientFactory) {
            _clientFactory = clientFactory;
        }

        [Route("/")]
        public async Task<IActionResult> Index() {
            HttpClient serverClient = _clientFactory.CreateClient();
            DiscoveryDocumentResponse discoverDocument = await serverClient.GetDiscoveryDocumentAsync("https://localhost:5003");
            TokenResponse token = await serverClient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest {
                Address = discoverDocument.TokenEndpoint,
                ClientId = "client_id",
                ClientSecret = "client_secret",
                Scope = "ApiOne"
            });

            HttpClient apiClient = _clientFactory.CreateClient();
            apiClient.SetBearerToken(token.AccessToken);
            HttpResponseMessage responseMessage = await apiClient.GetAsync("https://localhost:5005/secret");
            string content = await responseMessage.Content.ReadAsStringAsync();
            return Ok(new {
                access_token = token.AccessToken,
                message = content
            });
        }
    }
}
