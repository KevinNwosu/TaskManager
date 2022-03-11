TaskManager();

static void TaskManager()
{
    string[] taskList = { "Cook", "Clean", "Laundry", "Mow The Lawn", "Work" };

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
            AddTask(taskList);
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
        Console.WriteLine($"{i + 1}. {taskList[i]}");
    Console.WriteLine("=================================");
}
static void ViewTask(string[] taskList)
{
    TaskListDisplay(taskList);
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    TaskManager();

}
static void AddTask(string[] taskList)
{
    Console.Write("Enter Task: ");
    string newTask = Console.ReadLine();
    bool status = Array.Exists(taskList, element => element == newTask);
    Console.WriteLine($"{status}");
}
