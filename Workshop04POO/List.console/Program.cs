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
            Console.WriteLine(list);
            break;
        case "3":
            Console.WriteLine(list.ToStringReverse());
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            break;
        case "7":
            break;
        case "8":
            break;
        case "9":
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
    Console.WriteLine("1.Add occurrence");//Adicionar. ---
    Console.WriteLine("2.Show forward");//Mostar hacia adelante. ---
    Console.WriteLine("3.Show backward");//Mostar hacia atrás. ---
    Console.WriteLine("4.To order");//Ordenar decentemente.
    Console.WriteLine("5.fashion");//Mostrar la(s) moda(s).
    Console.WriteLine("6.Chart");//Mostrar gráfico.
    Console.WriteLine("7.It exists");//Existe.
    Console.WriteLine("8.Delete occurrence");//Eliminar una ocurrencia.
    Console.WriteLine("9.Remove all occurrences");//Eliminar todas las ocurrencias.
    Console.WriteLine("0.Exit");// Salir ---
    Console.WriteLine("Enter your option:   ");

    return Console.ReadLine() ?? string.Empty;
}












