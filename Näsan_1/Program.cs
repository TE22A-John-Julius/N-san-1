// if (6 >= 3)
// {
//     Console.WriteLine("Hello World!");
// }

/*-----------------------------------------------------*/

// Console.WriteLine("Give your username:");

// string user = Console.ReadLine().ToLower();

// if (user == "noname")
// {
//     Console.WriteLine("Welcome!");
// }

/*-----------------------------------------------------*/

// Console.WriteLine("Give your username:");

// string user = Console.ReadLine().ToLower();

// Console.WriteLine($"{user} give your password:");

// string password = Console.ReadLine().ToLower();

// if (user == "noname" && password == "nopass")
// {
//     Console.WriteLine("Welcome!");
// }

/*-----------------------------------------------------*/

// Console.WriteLine("Give your username:");

// string user = Console.ReadLine().ToLower();

// Console.WriteLine($"{user} give your password:");

// string password = Console.ReadLine().ToLower();

// if (user == "noname" && password == "nopass")
// {
//     Console.WriteLine("Welcome!");
// }
// else
// {
//     Console.WriteLine("Wrong username or password!");

// }
/*-----------------------------------------------------*/

// int amt = 1;

// while (amt <= 32)
// {
//     Console.WriteLine($"Hello World! {amt}");
//     amt++;
// }

/*-----------------------------------------------------*/

// bool correctPassword = false;

// while (correctPassword == false)
// {

//     Console.WriteLine("Give your username:");

//     string user = Console.ReadLine().ToLower();

//     Console.WriteLine($"{user} give your password:");

//     string password = Console.ReadLine().ToLower();

//     if (user == "noname" && password == "nopass")
//     {
//         Console.WriteLine("Welcome!");
//         correctPassword = true;
//     }
//     else
//     {
//         Console.WriteLine("Wrong username or password!");
//     }

// }
// Console.WriteLine("You have sucessfully logged in");

/*-----------------------------------------------------*/
for (int i = 0; i <= 4; i++)
{
    Console.WriteLine("Write a number");
    string number = Console.ReadLine();
    int userNumber = int.Parse(number);

    if (userNumber > 5)
    {
        Console.WriteLine("Higher than 5");
    }
}
Console.ReadLine();
