using System.Reactive;
using System.Windows.Input;
using ReactiveUI;
namespace BPMDesktopUi.ViewModels {
    public class LoginWindowViewModel : ViewModelBase {
        public ICommand LoginCommand { get; }
        public LoginWindowViewModel() {
            LoginCommand = ReactiveCommand.Create(() => {

            });
        }
    }
}
