namespace BlazorApp1.model;

public class ToDo
{
    public int id;

    public ToDo(int id, string title, string content)
    {
        this.id = id;
        this.title = title;
        this.content = content;
    }

    public string title { get; set; }
    public string content { get; set; }

    public bool isDone { get; set; } = false;   
}