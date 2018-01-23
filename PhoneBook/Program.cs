using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phonebook = new PhoneBook();
            Console.WriteLine("ADD CONTACT --------------  Press 1");
            Console.WriteLine("REMOVE CONTACT -----------  Press 2");
            Console.WriteLine("FIND CONTACT -------------  Press 3");
            Console.WriteLine("PRINT ALL CONTACTS -------  Press 4");
            Console.WriteLine("EXIT ---------------------  Press 5");

            do
            {
                string keyWord = Console.ReadLine();
                switch(keyWord)
                {
                    case "1":
                        Console.Write("Name:  ");
                        string name = Console.ReadLine();
                        Console.Write("Phone Number:   ");
                        string phoneNumber = Console.ReadLine();
                        phonebook.Add(new Record(name, phoneNumber));
                        Console.Write($"Contact \"{name}\" is added");
                        break;
                    case "2":
                        Console.Write("NAME:  ");
                        name = Console.ReadLine();
                        phonebook.Remove(phonebook[name]);
                        Console.Write($"Contact \"{name}\" removed");
                        break;
                    case "3":
                        Console.WriteLine("NAME:  ");
                        name = Console.ReadLine();
                        Console.Write(phonebook[name]);
                        break;
                    case "4":
                        phonebook.Display();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("Enter valid number ");
                        break;
                }
            } while (true);
        }
    }
}
