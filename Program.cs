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
            RemoveTask(taskList);
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
    //resize array if all 5 spot are full
}
static string[] RemoveTask(string[] taskList)
{
    TaskListDisplay(taskList);
    string message = "Enter Item to remove: ";
    int item = PromptUserForNum(message);
    if (item > 0 && item <= taskList.Length)
    {
        taskList[item-1] = null;
        for (int i = item - 1; i < taskList.Length - 1; i++)
        {
            taskList[i] = taskList[i + 1];
        }
        taskList[taskList.Length - 1] = null;
    }
    

    Console.ReadKey();
    TaskManagerMenu(taskList);
    return taskList;
}
static string PromptUser(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}
static int PromptUserForNum(string message)
{
    bool isValid = false;
    int numb;
    do
    {

        string input = PromptUser(message);

        if (int.TryParse(input, out numb))
        {
            isValid = true;
        }
        else
        {
            Console.WriteLine("That is not a valid number, try again!");
        }
    } while (!isValid);
    return numb;
}