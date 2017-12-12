using LibraryProgramConsole.Domain;
using LibraryProgramConsole.Domain.Users;
using System.Collections.Generic;

public class Library : IState
{
    public List<Order> Order { get; set; }

    public List<Book> BookSource = new List<Book>
            {
                new Book("Stary człowiek i morze", 420, BookType.Comedy),
                new Book("The Ring", 370, BookType.Horror),
                new Book("O psie który jeździł koleją", 256, BookType.Comedy),
                new Book("Stary człowiek i morze 2", 420, BookType.Comedy),
                new Book("The Ring 2", 370, BookType.Horror),
                new Book("O psie który jeździł koleją 2", 256, BookType.Comedy),
            };

    public bool IsOpen { get; set; }

    public Library(bool state, List<Order> list)
    {
        IsOpen = false;
        Order = list;
    }

    public void Close()
    {
        IsOpen = false;
    }

    public void Open()
    {
        IsOpen = true;
    }

    public void RentBook(Customer customer, Book book)
    {
        BookSource.Remove(book);
        Order.Add(new Order(customer, book));
    }

    public void ReceiveBook(Customer customer, Book book)
    {
        Order.Remove(new Order(customer, book));
        BookSource.Add(book);
    }

    public List<Order> StatusOrder(Customer customer)
    {
        return Order.FindAll(x => x.BookReader == customer && x.Status == false);
    }

}