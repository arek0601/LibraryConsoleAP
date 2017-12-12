using LibraryProgramConsole.Domain;
using LibraryProgramConsole.Domain.Users;
using System;
using System.Collections.Generic;

public class ConsoleMenu
{
    Library _library = new Library(false, new List<Order>());

    Customer _customer = new Customer("Arek", "Pawelak");

    public void StartMenu()
    {
        int option = ShowMainMenu();
        switch (option)
        {
            case 1:
                CustomerMainMenu();
                break;
            case 2:
                ShowWorkerMenu();
                break;
            case 3:
                break;
            default:
                break;
        }
    }

    public int ShowMainMenu()
    {
        Console.Clear();
        Console.WriteLine($"1. {UserType.Customer} \n2. {UserType.Worker} \n3. Leave library");
        return int.Parse(Console.ReadLine());
    }

    public void ShowWorkerMenu()
    {
        Console.Clear();
        string choice;

        if (_library.IsOpen)
        {
            Console.WriteLine($"1. Close library [Y]es [N]o?");
            choice = Console.ReadLine();

            if (choice == "Y")
            {
                _library.Close();
                StartMenu();
            }
            else
            {
                StartMenu();
            }
        }
        else
        {
            Console.WriteLine($"1. Open library [Y]es [N]o?");
            choice = Console.ReadLine();
            if (choice == "Y")
            {
                _library.Open();
                StartMenu();
            }
            else
                StartMenu();
        }
    }

    public void CustomerMainMenu()
    {
        if (_library.IsOpen)
        {
            Console.Clear();
            Console.WriteLine("1. Rent a book \n2. Receive book");

            if (int.Parse(Console.ReadLine()) == 1)
                RentBookMenu();
            else
                ReceiveBookMenu();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Sorry library is closed");
            Console.ReadKey();
            StartMenu();
        }
    }

    public void RentBookMenu()
    {
        LibraryStateTable(_library.BookSource);
        Book bookToRent = null;
        Console.WriteLine("Enter title: ");
        string tittleToRent = Console.ReadLine();
        bookToRent = _library.BookSource.FindLast(x => x.Title == tittleToRent);

        if (bookToRent != null)
        {
            _library.RentBook(_customer, bookToRent);
            CustomerMainMenu();
        }
        else
        {
            Console.WriteLine("You didn't choose correct book");
            Console.ReadKey();
            RentBookMenu();
        }
    }

    public void ReceiveBookMenu()
    {
        Book bookToReturn = null;
        Table.ShowHeader(" Tittle ", " Type ", " Page Count ");
        List<Order> list = _library.StatusOrder(_customer);

        foreach (Order order in list)
        {
            Console.WriteLine(String.Format("{0,-30} | {1,16} | {2,14} |", order.BookRent.Title, order.BookRent.Type, order.BookRent.PageCount));
            Console.WriteLine("------------------------------------------------------------------");
        }

        Console.WriteLine("Enter title: ");
        string tittleToReturn = Console.ReadLine();

        try
        {
            bookToReturn = _library.Order.FindLast(x => x.BookRent.Title == tittleToReturn).BookRent;
            _library.Order.Remove(_library.Order.FindLast(x => x.BookRent.Title == tittleToReturn));
            _library.BookSource.Add(bookToReturn);
            CustomerMainMenu();
        }
           
        catch(NullReferenceException nrE)
        {
            Console.WriteLine(nrE.Message);
            Console.ReadKey();
            CustomerMainMenu();
        }
    }

    public void LibraryStateTable(List<Book> bookList)
    {
        Table.ShowHeader(" Tittle ", " Type ", " Page Count ");

        foreach (Book book in bookList)
        {
            Console.WriteLine(String.Format("{0,-30} | {1,16} | {2,14} |", book.Title, book.Type, book.PageCount));
            Console.WriteLine("------------------------------------------------------------------");
        }
    }
}
