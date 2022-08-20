using sisu.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace sisu.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
