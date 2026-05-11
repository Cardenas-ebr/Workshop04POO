using DoubleList;

var list = new DoubleLinkedList<string>();
var option = string.Empty;
var value = string.Empty;

do
{
    option = Menu();
    switch (option)
    {
        case "1":
            Console.WriteLine("Enter a value:  ");
            value = Console.ReadLine() ?? string.Empty;
            list.AddOccurrence(value);
            break;
        case "2":
            Console.WriteLine(list.ShowForward());
            break;
        case "3":
            list.ShowBackward();
            Console.WriteLine(list);
            break;
        case "4":
            list.ToOrder();
            Console.WriteLine(list.ToString());
            break;
        case "5":
            var fashions = list.Fashion();

            Console.WriteLine("The fashion(s) is: ");

            foreach (var item in fashions)
            {
                Console.WriteLine(item);
            }
            break;
        case "6":
            Console.WriteLine(list.Chart());
            break;
        case "7":
            Console.WriteLine("Enter a value:  ");
            value = Console.ReadLine() ?? string.Empty;
            var exists = list.ItExists(value);
            if (exists)
            {
                Console.WriteLine($"value '{value}' found in the list.");
            }
            else
            {
                Console.WriteLine($"value '{value}' not found in the list.");
            }
            break;
        case "8":
            Console.WriteLine("Enter a value:  ");
            value = Console.ReadLine() ?? string.Empty;
            list.DeleteOccurrence(value);
            break;
        case "9":
            list.RemoveAllOccurrences();
            Console.WriteLine("Lista eliminada.");
            break;
        case "0":
            Console.WriteLine("Exiting....");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
} while (option != "0");
string Menu()
{
    Console.WriteLine("1.Add occurrence");
    Console.WriteLine("2.Show forward");
    Console.WriteLine("3.Show backward");
    Console.WriteLine("4.To order");
    Console.WriteLine("5.fashion");
    Console.WriteLine("6.Chart");
    Console.WriteLine("7.It exists");
    Console.WriteLine("8.Delete occurrence");
    Console.WriteLine("9.Remove all occurrences");
    Console.WriteLine("0.Exit");
    Console.WriteLine("Enter your option:   ");

    return Console.ReadLine() ?? string.Empty;
}

