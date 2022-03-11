string[] taskList = new string[5];
TaskManagerMenu(taskList);
static void TaskManagerMenu(string[] taskList)
{
    
    Console.Clear();
    Console.WriteLine("Task Manager");
    Console.WriteLine("=================================");
    Console.WriteLine("1. View List");
    Console.WriteLine("2. Add a Task");
    Console.WriteLine("3. Remove a Task");

    Console.WriteLine("\nPress Q to quit");
    Console.WriteLine("=================================");
    string userInput = Console.ReadLine().ToLower();

    switch (userInput)
    {
        case "1":
            ViewTask(taskList);
            break;
        case "2":
            taskList = AddTask(taskList);
            break;
        case "3":
            // Remove task function
            break;
        case "q":
            Console.WriteLine("Goodbye!");
            break;

    }

}
static void TaskListDisplay(string[] taskList)
{
    Console.Clear();
    Console.WriteLine("Task List");
    Console.WriteLine("=================================");
    for (int i = 0; i < taskList.Length; i++)
        if (!string.IsNullOrEmpty(taskList[i]))
        Console.WriteLine($"{i + 1}. {taskList[i]}");
    Console.WriteLine("=================================");
}
static void ViewTask(string[] taskList)
{
    TaskListDisplay(taskList);
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    TaskManagerMenu(taskList);

}
static string[] AddTask(string[] taskList)
{
    Console.Write("Enter Task: ");
    string newTask = Console.ReadLine();
    bool status = Array.Exists(taskList, element => element == newTask);
    if (!status)
    {
        for (int i = 0; i < taskList.Length; i++)
        {
            if (string.IsNullOrEmpty(taskList[i]))
            {
                taskList[i] = newTask;
                break;
            }
                    }
        Console.WriteLine("It's been added to the list");
        Console.ReadKey();
        TaskManagerMenu(taskList);
        return taskList;    

    }
    else
    {
        Console.WriteLine("It's on the list!");
        Console.ReadKey();
        TaskManagerMenu(taskList);
        return taskList;
    }
    
}
