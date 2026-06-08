using Lens.Models;

namespace Lens.ViewModels {
    public class RowsShownViewModel {
        public RowShownModel Selected { get; set; }
        public List<RowShownModel> RowsShownItems { get; set; }

        public RowsShownViewModel() {
            RowsShownItems = [
                new() { Id = 1, RowShownName = "10" },
                new() { Id = 2, RowShownName = "20" },
                new() { Id = 3, RowShownName = "50" },
            ];

            Selected = RowsShownItems[0];
        }
    }
}
