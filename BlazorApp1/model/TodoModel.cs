namespace BlazorApp1.model;

public class TodoModel
{
    private List<ToDo> todoList=[];

   public void Add(string title, string content)
    {
        todoList.Add(new ToDo(todoList.Count+1, title, content));
    }
    void delete(int id)
    {
        todoList.RemoveAt(id);
    }

    public void showTodoList()
    {
        foreach (var toDo in todoList)
        {
            Console.WriteLine($"ID:{toDo.id} title:{toDo.title} content:{toDo.content}");
        }
    }
}