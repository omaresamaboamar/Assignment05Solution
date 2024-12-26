



#region Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

//Console.WriteLine("Enter your number");
//Console.WriteLine();
//int.TryParse(Console.ReadLine(), out int n);
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        if (i == j)

//            Console.Write("1 ");

//        else

//            Console.Write("0 ");

//    }
//    Console.WriteLine();
//}
#endregion
#region Write a program in C# Sharp to find the sum of all elements of the array.
//int sum = 0;
//int[] numbers = { 2, 5, 4, 7, 6, 2 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}
//Console.WriteLine(sum);
#endregion
#region Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
//Console.WriteLine("Enter your size of array: ");
//int.TryParse(Console.ReadLine(), out int size);
//int[] array1 = new int[size];
//int[] array2 = new int[size];
//Console.WriteLine("Enter your Element in the first array");
//for (int i = 0; i < size; i++)
//{
//    Console.WriteLine($"Element {i + 1}");
//    array1[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Enter your in the second of array:");
//for (int i = 0;i < size; i++)
//{
//    Console.WriteLine($"Element {i + 1}");
//    array2[i]=int.Parse(Console.ReadLine());
//}

//int[] mergedArray = new int[size * 2];
//for (int i = 0; i < size; i++)
//{
//    mergedArray[i] = array1[i];
//    mergedArray[size + i] = array2[i];
//}

//Array.Sort(mergedArray);

//Console.WriteLine("The merged and sorted array is:");
//foreach (int element in mergedArray)
//{
//    Console.Write(element + " ");
//}
//Console.WriteLine();

#endregion
#region Write a program in C# Sharp to find maximum and minimum element in an array

//Console.Write("enter your number of size: ");
//int.TryParse(Console.ReadLine(), out int size);
//int[] array = new int[size];
//Console.WriteLine("Enter yout Element of Array");
//for (int i = 0; i < size; i++)
//{
//    Console.WriteLine($"Entrt your element {i + 1}");
//    array[i] = int.Parse(Console.ReadLine());   
//}
//int max = array[0];
//int min = array[0];

//for (int i = 1; i < size; i++)
//{
//    if (array[i] > max)
//       max = array[i]; 
//    else if (array[i] < min)
//       min = array[i];
//}
//Console.WriteLine($"The maximum element in the array is: {max}");
//Console.WriteLine($"The minimum element in the array is: {min}");
#endregion
#region Write a program in C# Sharp to find the second largest element in an array.

//Console.Write("enter your number of size your array: ");
//int.TryParse(Console.ReadLine(), out int size);
//int[] array = new int[size];
//Console.WriteLine("Enter yout Element of Array");
//for (int i = 0; i < size; i++)
//{
//    Console.WriteLine($"Entrt your element {i + 1}");
//    array[i] = int.Parse(Console.ReadLine());
//}
//Array.Sort(array);
//Array.Reverse(array);
//Console.WriteLine(array[1]);
#endregion
#region Given a list of space separated words, reverse the order of the words.Input: this is a test Output: test a is this
//string message;
//Console.WriteLine("Enter your message ");
//message = Console.ReadLine();
//Console.WriteLine(string.Join(" ",message.Split(' ').Reverse()));
#endregion
#region Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.
//Console.WriteLine("Enter your Rows:");
//int.TryParse(Console.ReadLine(), out int rows);
//Console.WriteLine("Enter your Columns:");
//int.TryParse(Console.ReadLine(), out int columns);
//int[,] array1 = new int[rows,columns];
//int[,] array2 = new int[rows, columns];
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.WriteLine($"enter your ({ i + 1 },{ j + 1 }):");
//        array1[i,j] = int.Parse(Console.ReadLine());
//    }
    
//}

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.WriteLine($"enter your ({i + 1},{j + 1}):");
//        array2[i,j] = array1[i,j];    
//    }
//}
//Console.WriteLine("Second array (copied from the first array):");
//for (int i = 0;i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write(array2[i, j] + " ");
//    }
//        Console.WriteLine();
//}
#endregion 
#region Write a Program to Print One Dimensional Array in Reverse Order
//Console.Write("Enter the size of the array: ");
//int.TryParse(Console.ReadLine(),out int size);
//int[] array = new int[size];
//Console.WriteLine("Enter elements for the array:");
//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Element {i + 1}: ");
//    array[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Array in reverse order:");
//for (int i = size - 1; i >= 0; i--)
//{
//    Console.Write(array[i] + " ");
//}
//Console.WriteLine();
#endregion








