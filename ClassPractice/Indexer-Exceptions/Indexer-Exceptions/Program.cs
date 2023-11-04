

using Indexer_Exceptions;
using Indexer_Exceptions.Controllers;
using Indexer_Exceptions.Exceptions;
using Indexer_Exceptions.Helpers.Constants;
using Indexer_Exceptions.Models;

#region Indexer
//Library library = new Library();

//Book book = new Book();
//book.Id = 1;

//book.Name = "Test1";

//library[0] = book;

//Console.WriteLine(library[0].Name);
#endregion



//try
//{
//    int a = 5;
//    int b = 0;

//    int result = a / b;

//    Console.WriteLine(result);

//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Hi Azerbaijan");
//}


static void Register(string username, string password)
{
    bool isSuccess = false;

    try
    {
        if (username == "aqshin123")
        {
            Console.WriteLine("Registration is successfully");
            isSuccess = true;
        }
        else
        {
            throw new RegisterFailedException();

        }

    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }

    finally
    {
        SendEmail(isSuccess);
    }
}

//Register("aqshin12", "nsdaml");


static void SendEmail(bool isSuccess)
{
    if (isSuccess)
    {
        Console.WriteLine(AccountMessages.EmailSuccess);
    }
    else
    {
        Console.WriteLine(AccountMessages.EmailFailed);
    }
}

ShowText(null);

static void ShowText(string text)
{    
    try
    {
        if (text is null)
        {
            throw new ArgumentNullException();
        }
        else
        {
            Console.WriteLine(text);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

PersonController personController = new();

personController.GetById();  


