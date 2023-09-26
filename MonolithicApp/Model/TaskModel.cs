namespace MonolithicApp.Model;

public class TaskModel
{
    private List<TaskEntity> tasks = new List<TaskEntity>();

    public List<TaskEntity> GetAll()
    {
        return tasks;
    }

    public TaskEntity GetByID(int id)
    {
        TaskEntity task = tasks.Find(item => item.ID == id);

        if (task == null)
        {
            return new TaskEntity
            {
                ID = 0,
                Task = "Not Found",
                Category = ""
            };
        }

        return task;
    }

    public bool Delete(int id)
    {
        int taskIndex = tasks.FindIndex(item => item.ID == id);

        if (taskIndex < 0)
        {
            return false;
        }

        tasks.RemoveAt(taskIndex);
        return true;
    }

    public bool Update(int id, string task, string category)
    {
        int taskIndex = tasks.FindIndex(item => item.ID == id);

        if (taskIndex < 0)
        {
            return false;
        }

        tasks[taskIndex].Task = task;
        tasks[taskIndex].Category = category;

        return true;
    }

    public bool Insert(string task, string category)
    {
        int lastIndex = tasks.Count - 1;

        int id = lastIndex == -1 ? id = 0 : tasks[lastIndex].ID + 1;

        tasks.Add(new TaskEntity
        {
            ID = id,
            Task = task,
            Category = category
        });

        return true;
    }

}
