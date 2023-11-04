

using Indexer_Exceptions;

Datalist<Person> list = new();

#region TASK 2
list.Add(new Person { Id = 1, Name = "Agshin", Surname = "Veliyev", Age = 26 });
list.Add(new Person { Id = 2, Name = "Semed", Surname = "Huseynov", Age = 27 });
list.Add(new Person { Id = 3, Name = "Ilham", Surname = "Abasli", Age = 20 });

//var datas = list.GetById(1);

//Console.WriteLine(datas.Name + "-" + datas.Surname + "-" + datas.Age);
#endregion

#region TASK 3
var datas = list.DeleteMethod(3);

foreach (var item in datas)
{
    //Console.WriteLine(item.Name + "-" + item.Surname + "-" + item.Age);
}
#endregion



static void GetFactorial()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Enter a number");

    int number = int.Parse(Console.ReadLine());

    int factorial = number;

    try
    {
        if (number < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine(FactorialMessages.NumberFailed);
        }
        else
        {
            for (int i = 1; i < number; i++)
            {
                factorial *= i;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(factorial);
        }

        

    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
    

}

GetFactorial();










