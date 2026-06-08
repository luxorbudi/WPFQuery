using Lens.Models;

namespace Lens.ViewModels {
    public class EnvironmentViewModel {
        public EnvironmentModel Selected {  get; set; }
        public List<EnvironmentModel> EnvironmentItems { get; set; }

        public EnvironmentViewModel() {
            EnvironmentItems = [
                new() { Id = 1, EnvironmentName = "Calidad" }, 
                new() { Id = 2, EnvironmentName = "Test" }
            ];

            Selected = EnvironmentItems[0];
        }
    }
}
