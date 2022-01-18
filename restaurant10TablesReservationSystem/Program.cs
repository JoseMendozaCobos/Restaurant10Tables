using System;
/*
    1. Validar si es usuario existente o si se debe registrar, y generar un sistema de registro/login
    2. El programa debe ser capaz de darle la bienvenida al usuario existente si en efecto existe
    3.El programa debe repetirse hasta que se registren las 10 personas
 */
namespace restaurant10TablesReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10] { "Royber", "Rosnier", "Jose", "Alicia", "Francisco","Ricardo","Ronny", "Rafael","Maria","" };
            int arrayCurrentIndex = 9;
            bool userType;
            
            Console.WriteLine("Welcome to the best restaurant in the world!");
            
            while (arrayCurrentIndex < 10)
            {

                /*if (arrayCurrentIndex == 10) {
                    Console.WriteLine("The restaurant is full, please try in another moment");
                    Environment.Exit(0);
                }*/


                Console.WriteLine("Are you registred user? Write true to log-in, or write false to register");
                userType = Convert.ToBoolean(Console.ReadLine());
                if (userType == true)
                {
                    Console.WriteLine("\nHello, you're a registred user, please enter your exact username");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user you searched is {0}", userToSearch);
                    //SI DA -1 ES QUE NO ENCONTRO EL ELEMENTO
                    int index = Array.IndexOf(userNames, userToSearch);
                    if (index == -1)
                    {
                        Console.WriteLine("User not found, try again or register");
                    }
                    else
                    {
                        Console.WriteLine("\nWelcome {0}, it's a pleasure to give you food", userNames[index]);
                    }
                }
                else if (userType == false) 
                {
                    Console.WriteLine("Please write and remember your username");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("Sucessfull this is your username > {0} \nYou're a registred user now!!!", userNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;
                }
            }
            Console.WriteLine("The restaurant is full, try again in another moment\n There are the guest to the dinner: ");
            int auxIndex = 0;
            foreach (string element in userNames) 
            {
                Console.WriteLine("User number {0} and user name: {1}", auxIndex+1, userNames[auxIndex]);
                auxIndex++;
            }
            Environment.Exit(0);
        }
    }
}
