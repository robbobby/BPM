using System;
using System.Data;
using System.Reactive;
using BPMDesktopUi.Services;
using ReactiveUI;

namespace BPMDesktopUi.ViewModels {
    public class MainWindowViewModel : ReactiveObject {
        private bool _isSideBarExpanded = true;
        public ProjectListViewModel ProjectList { get; set; }
        public ReactiveCommand<Unit, Unit> ToggleSize { get; }
        public MainWindowViewModel(MockProjectDb projectDb) {
            ProjectList = new ProjectListViewModel(projectDb.GetProjects());
            ToggleSize = ReactiveCommand.Create(ToggleMenuSize);
        }
        private void ToggleMenuSize() {
            Console.WriteLine("hello");
            _isSideBarExpanded = !_isSideBarExpanded;
            SideBarWidth = _isSideBarExpanded ? 50 : 200;
        }

        private int _sizeBarWidth = 50;
        public int SideBarWidth {
            get => _sizeBarWidth;
            set => this.RaiseAndSetIfChanged(ref _sizeBarWidth, value);
        }
    }
}
