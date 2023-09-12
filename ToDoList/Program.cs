namespace ToDoList
{
    internal class Program
    {

        public List<string> todoList = new List<string>();
        public void PromptUser()
        {
            
            Console.WriteLine("Would you like to add, update or delete a todo? to close type 'end'");
            string userOption = Console.ReadLine();

            if (userOption != null)
            {
                if (userOption.ToLower() == "add")
                {
                    Console.WriteLine("Add a todo to the todo list:");
                    todoList.Add(Console.ReadLine());
                }
                else if (userOption.ToLower() == "update")
                {
                    Console.WriteLine("Which todo would you like to update?");
                    for (int i = 0; i < todoList.Count; i++)
                    {
                        Console.WriteLine($"{i+1}. {todoList[i]}");
                    }
                    try
                    {
                        Console.WriteLine("What todo would you like to update?");
                        for (int i = 0; i < todoList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {todoList[i]}");
                        }
                        int index = (int.Parse(Console.ReadLine()) - 1);
                        Console.WriteLine("Enter what you would would like to update the todo to.");
                        todoList[index] = Console.ReadLine();
                        Console.WriteLine("Successfully updated.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (userOption.ToLower() == "delete")
                {
                    Console.WriteLine("Which todo would you like to delete?");
                    
                    for (int i = 0; i < todoList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {todoList[i]}");
                    }
                    try
                    {

                        todoList.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                        Console.WriteLine("Successfully deleted.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (userOption.ToLower() == "end")
                {
                    return;
                }
            }
            Console.WriteLine("TODO LIST:");
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
            PromptUser();
        }

        static void Main(string[] args)
        {
            var newProgram = new Program();
            newProgram.PromptUser();
        }
    }
}