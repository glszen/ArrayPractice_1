internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[10]; //Create new array

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (var item in numbers) //Write array
        {
            Console.WriteLine(item);
        }

        //Create a new array and copy previous array
        Console.Write("Enter a new value");
        int newValue = Convert.ToInt32(Console.ReadLine());

        int[] newNumbers = new int[11]; //New array

        for (int i = 0; i < numbers.Length; i++) //Every value copy new array
        {
            newNumbers[i] = numbers[i]; //Copy values
        }

        newNumbers[10] = newValue; //Add new index

        Array.Sort(newNumbers); //Sorted array
        foreach (var item in newNumbers) //Write new array
        {
            Console.WriteLine(item);
        }
    }
}