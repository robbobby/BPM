using System.Linq;
using System.Security.Principal;
using BPMDesktopUi.DataAccess.Identity;
namespace BPMDesktopUi.DataAccess {
    public class CustomPrincipal : IPrincipal {
        
        public CustomIdentity _identity;
        IIdentity? IPrincipal.Identity => _identity;
        
        public CustomIdentity Identity {
            get => _identity ?? new AnonymousIdentity();
            set => _identity = value;
        }
        
        public bool IsInRole(string role) => _identity.Roles.Contains(role);
    }
}
