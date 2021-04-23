using System;
namespace BPMDesktopUi.DataAccess.Identity {
    public class AnonymousIdentity : CustomIdentity {

        public AnonymousIdentity()
            : base(string.Empty, Array.Empty<string>(), string.Empty) {
        }
    }
}
