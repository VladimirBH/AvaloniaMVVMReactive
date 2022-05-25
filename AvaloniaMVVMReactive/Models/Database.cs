using System.Collections;
using System.Collections.Generic;

namespace AvaloniaMVVMReactive.Models;

public class Database
{
    public IEnumerable<TodoItem> GetItems() => new[]
    {
        new TodoItem{Description = "Walk the dog"},
        new TodoItem{Description = "Buy some milk"},
        new TodoItem{Description = "Learn Avalonia", IsChecked = true}
    };

}