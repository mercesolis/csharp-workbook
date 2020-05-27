using System;
using System.Collections.Generic;

namespace TodoApp1
{
    public class App
    {
        ConsoleUtils consoleUtils;
        ItemRepository itemRepository;

        public App()
        {
            consoleUtils = new ConsoleUtils();
            itemRepository = new ItemRepository();
        }

        public void Start()
        {
            // Print user's options

            bool quit = true;
            while (quit)
            {
                var response = consoleUtils.PrintMenu();
                switch (response)
                {
                    case 1:
                        var desc = consoleUtils.AddItem();
                        itemRepository.addItem(desc);
                        break;
                    case 2:
                        var id = consoleUtils.Delete();
                        itemRepository.delete(id);
                        break;
                    case 3:
                        var pending = consoleUtils.UpdateItem();
                        itemRepository.updateItem(pending);
                        break;
                    case 4:
                        List<ToDoItem> list = itemRepository.displayList();
                        consoleUtils.PrintList(list);
                        break;
                    case 5:
                        List<ToDoItem> done = itemRepository.doneList();
                        consoleUtils.PrintList(done);
                        break;
                    case 6:
                        List<ToDoItem> pendingList = itemRepository.pendingList();
                        consoleUtils.PrintList(pendingList);
                        break;
                    case 0:
                        quit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                

            
            

            }

            
        }


    }
}
