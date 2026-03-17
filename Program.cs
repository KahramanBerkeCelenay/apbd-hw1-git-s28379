// See https://aka.ms/new-console-template for more information
public static void SayHello() { 
	Console.WriteLine("Hello"); //Commit 1 

	int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
	Console.WriteLine("Array initialized."); //Commit 2
}

public static void PrintNumbers(int[] values) 
{
    foreach (var v in values) {
        Console.Write(v + " "); //Commit 3
    }
}


