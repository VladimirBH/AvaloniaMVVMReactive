using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AvaloniaMVVMReactive.Models;

namespace AvaloniaMVVMReactive.ViewModels;

public class TodoListViewModel : ViewModelBase
{
    public TodoListViewModel(IEnumerable<TodoItem> items)
    {
        Items = new ObservableCollection<TodoItem>(items);
    }
    public ObservableCollection<TodoItem> Items { get; }
}