using System.ComponentModel;

static void posNeg(int[,] matrix)
{
    Console.WriteLine();
    int posC = 0, negC = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > 0) posC++;
            else if (matrix[i,j] < 0) negC++;
            else Console.WriteLine("Element " + i + " " + j + "  of matrix is 0.");
        }
    }
    Console.WriteLine("Number of positive elements in the matrix: " + posC);
    Console.WriteLine("Number of negative elements in the matrix: " + negC);
    Console.WriteLine("To countinue press any key!");
    Console.ReadKey();
    Console.WriteLine();
}
static void sort(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])
                {
                    int t = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = t;
                }
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine("To countinue press any key!");
    Console.ReadKey();
    Console.WriteLine();
}
static void inverse(int [,]matrix)
{
   
    int M = matrix.GetLength(0);
    int N = matrix.GetLength(1);
    for (int i = 0; i < M; i++) {
        int start = 0;
        int end = N - 1;
        while (start < end) {
            int temp = matrix[i,start];
            matrix[i, start] = matrix[i, end];
            matrix[i, end] = temp;
            start++;
            end--;
        }
    }
    for (int i = 0; i < M; i++) {
        for (int j = 0; j < N; j++) {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("To countinue press any key!");
    Console.ReadKey();
    Console.WriteLine();
}





Console.WriteLine("Enter the number of rows and columns: ");
int[,] mainMatrix = new int [Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())]; 
for (int i = 0; i < mainMatrix.GetLength(0); i++)
{
	for (int j = 0; j < mainMatrix.GetLength(1); j++)
	{
		Console.WriteLine("Enter " + i + " " + j + " element of matrix: ");
		mainMatrix[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int i = 0; i < mainMatrix.GetLength(0); i++)
{
    
    for (int j = 0; j < mainMatrix.GetLength(1); j++)
    {
        Console.Write(mainMatrix[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
bool @try = true;
while (@try)
{
    Console.WriteLine("Make a choice: \n" + "1. Positive/negative elements\n" + "2. Sort\n" + "3. Inverse\n" + "4. Programm exit.\n");
    int menu = Convert.ToInt32(Console.ReadLine());
    switch (menu)
    {
        case 1:
            posNeg(mainMatrix);
            break;
        case 2:
            sort(mainMatrix);
            break;
        case 3:
            inverse(mainMatrix);
            break;
        case 4:
            @try = false;
            break;
    }
}
