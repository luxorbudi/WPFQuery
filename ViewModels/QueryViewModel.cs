using Lens.Models;

namespace Lens.ViewModels {
    public class QueryViewModel {
        public QueryModel Selected {  get; set; }
        public List<QueryModel> QueryItems { get; set; }

        public QueryViewModel() {
            QueryItems = [
                new() { Id = 1, QueryName = "Empresas" }, 
                new() { Id = 2, QueryName = "Convenios" },
                new() { Id = 3, QueryName = "Configuraciones" },
                new() { Id = 4, QueryName = "Logs" },
            ];

            Selected = QueryItems[3];
        }
    }
}
