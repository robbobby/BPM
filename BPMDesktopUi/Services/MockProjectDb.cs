using System.Collections.Generic;
using System.Linq;
using BPMDesktopUi.Models;

namespace BPMDesktopUi.Services {
    public class MockProjectDb {
        public IEnumerable<ProjectModel> GetProjects() => new[] {
            new ProjectModel() {
                Name = "Project 1",
                ProjectMembers = MockUserDb.GetUsers().ToList()
            },
            new ProjectModel() {
                Name = "Project 2",
                ProjectMembers = MockUserDb.GetUsers().ToList()
            }
        };
    }
}
