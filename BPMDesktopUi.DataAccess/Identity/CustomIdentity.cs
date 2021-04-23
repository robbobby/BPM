using System.Security.Principal;
namespace BPMDesktopUi.DataAccess.Identity {
    public class CustomIdentity : IIdentity {
        public string Name { get; private set; }
        public string[] Roles { get; private set; }
        public string EmailAddress { get; private set; }
        public CustomIdentity(string name, string[] roles, string emailAddress) {
            Name = name;
            Roles = roles;
            EmailAddress = emailAddress;
        }

        public string AuthenticationType => "Custom Authentication";
        public bool IsAuthenticated => !string.IsNullOrEmpty(Name);
    }
}
