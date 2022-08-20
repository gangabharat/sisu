using sisu.Application.Common.Mappings;
using sisu.Domain.Entities;

namespace sisu.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
