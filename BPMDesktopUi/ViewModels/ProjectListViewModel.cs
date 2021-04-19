using System.Collections.Generic;
using System.Collections.ObjectModel;
using BPMDesktopUi.Models;
namespace BPMDesktopUi.ViewModels {
    public class ProjectListViewModel : ViewModelBase {
        public ObservableCollection<ProjectModel> Projects { get; }
        
        public ProjectListViewModel(IEnumerable<ProjectModel> projects) {
            Projects = new ObservableCollection<ProjectModel>(projects);
        }
    }
}
