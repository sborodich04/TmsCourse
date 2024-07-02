bool @try = true;
static void Summary(int firstN, int secondN)
{
    Console.WriteLine("Result of addition operation: " + (firstN + secondN));
}
static void Subtraction(int firstN, int secondN)
{
    Console.WriteLine("Result of substraction operation: " + (firstN - secondN));
}
static void Multiplication(int firstN, int secondN)
{
    Console.WriteLine("Result of multiplication operation: " + (firstN * secondN));
}
static void Division(int firstN, int secondN)
{
    Console.WriteLine("Result of division operation: " + (firstN / secondN));
}


while (@try)
{
    int firstN = 0;
    int secondN = 0;
    Console.WriteLine("Enter first number: ");
    try
    {
         firstN = Convert.ToInt32(Console.ReadLine());
    }
    catch {
        Console.WriteLine("Enter only numbers!");
        break;
    }
    Console.WriteLine("Enter second number: ");
    try
    {
        secondN = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Enter only numbers!");
        break;
    }
    Console.WriteLine("Make a choice: \n" + "1. Addition\n" + "2. Subtraction\n" + "3. Multiplication\n" + "4. Division\n" + "5. Programm exit.\n");
    int menu = Convert.ToInt32(Console.ReadLine()); 
    switch (menu)
    {
        case 1:
               Summary(firstN, secondN);
            break;
        case 2:
            Subtraction(firstN, secondN);
            break;
        case 3:
            Multiplication(firstN, secondN);
            break;
        case 4:
            Division(firstN, secondN);
            break;
        case 5:
            Console.WriteLine("Exiting the programm.");
            Console.WriteLine("Exiting the programm..");
            Console.WriteLine("Exiting the programm...");
            @try = false;
            break;
    }
}