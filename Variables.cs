class Program
{
    static void Main(string[] args)
    {
        // int for whole numbers, float for up to 7 decimals and double for very precise numbers.
        double num01;
        double num02;
        double num03;

        Console.Write("Input a number: ");

        // if using int. Convert.ToInt32 instead of ToDouble.
        num01 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input a second number: ");
        num02 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input third number: ");
        num03 = Convert.ToDouble(Console.ReadLine());

        // Change what you want done with the number here. + / - *
        double result = num01 + num02 + num03;
        double averageResult = (num01 + num02 + num03) / 3;
        Console.WriteLine("The result of these numbers are " + result + ", and the average is " + averageResult + ".\nThank you for listening to my Ted talk.");

        // wait before closing
        Console.ReadKey();
    }
}