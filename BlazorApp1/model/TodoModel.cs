namespace BlazorApp1.model;

//TODO 弄成服务来进行注册，依赖注入的形式。
public class TodoModel
{
    private List<ToDo> todoList = [];

    public void Add(string title, string content)
    {
        todoList.Add(new ToDo(todoList.Count + 1, title, content));
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

    public async Task<List<ToDo>> getAllDataAsync()
    {
        // 模拟异步IO操作（如数据库查询/API调用）
        await Task.Delay(500);
        var result = new List<ToDo>{
            new ToDo(1, "标题一", "内容一"),
            new ToDo(2, "标题二", "内容二"),
            new ToDo(3, "标题三", "内容三")
        };
        return result;
    }
}