// See https://aka.ms/new-console-template for more information

public static void SayHello() { //Main Program
	Console.WriteLine("Hello"); //Commit 1 

	int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
	Console.WriteLine("Array initialized."); //Commit 2
	Console.WriteLine("Conflict Test 1");
}

public static void PrintNumbers(int[] values) 
{
	foreach (var v in values) {
        Console.Write(v + " "); //Commit 3
        }
}

public static double CalculateAverage(int[] numbers)
{
	int sum = 0;
	foreach (var n in numbers) sum += n; //Commit 4
	return (double)sum / numbers.Length;
}

public static int CalculateMax(int[] numbers)
{
	int max = numbers[0];
	foreach (var n in numbers)
	{
		if (n > max) max = n;  //Commit 5
	}                             
	return max;
}



public static int CalculateMin(int[] numbers)
{
	int min = numbers[0];
	foreach (var n in numbers)
	{
        if (n < min) min = n;
	}
	return min;
}
