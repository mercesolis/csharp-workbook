using System;
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
                var response = consoleUtils.GetUserOption();
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
                    var pending 
                    displayPending();
                    break;
                case 4:

                    displayList();
                    break;
                case 5:
                    printCompleted();
                    break;
                case 0:
                        quit = false;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            //enter new items
            

            }

            
        }


    }
}
