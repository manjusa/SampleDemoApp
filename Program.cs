//Normal 1DArray Sorting - Start

Console.WriteLine("Hello, World!");
int[] num = { 3, 7, 1, 2, 12, 10 };
Array.Sort(num);
num.ToList().ForEach(x => Console.WriteLine(x));

//Normal 1DArray Sorting - End

//Jagged Array Sorting using Custom Comparer - Start
/*
int[][] jaggedArray= new int[4][];
jaggedArray[0] = new int[] { 1, 2, 3 };*/
int[][] a = new int[][]
{
  new int[3]{5,88,19},
  new int[3]{99,1,11},
  new int[3]{22,07,88}
};
Array.Sort(a, new JaggedArrayCustomComparer());
printJaggedArray(a);

//Jagged Array Sorting using Custom Comparer - End

Console.WriteLine("-----------------------------------------------------");
//Jagged Array Sort by Custom column - Start

int i = 2;
Array.Sort(a, new JaggedArrayCustomComparer(i));
printJaggedArray(a);
void printJaggedArray(int[][] a)
{
    foreach (int[] x in a)
    {
        Console.WriteLine(string.Join(",", x));
    }
}

//Jagged Array Sort by Custom column - End

//Rectangular Array Sorting - Start

int[,] twoDimensionalArray = new int[,] { { 1, 3 }, { 15, 2 }, { 7, 10 }, { 22, 9 }, { 10, 14 } };
Console.WriteLine(twoDimensionalArray[0, 0]);
Console.WriteLine(twoDimensionalArray[0, 1]);
int[] trackingArray = { 0, 1, 2, 3, 4 };
Array.Sort(trackingArray, new MDArrayCustomComparer(twoDimensionalArray));
Console.WriteLine(trackingArray); // 0,2,4,1,3
printMDArray(trackingArray);
void printMDArray(int[] trackingArray)
{
    foreach (int i in trackingArray)
    {
        for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
        {
            Console.WriteLine(twoDimensionalArray[i, j]);
        }
        Console.WriteLine("--");
    }
}

//Rectangular Array Sorting - End

//Rectangular Array Sorting -converting array to list approach - Start

List<List<int>> listOfInts = convertArrayToList(twoDimensionalArray);
listOfInts = listOfInts.OrderBy(x => x[0]).ToList();
//convert list back to Array
int[,] sortedMDArray = convertListToArray(listOfInts);
printMDArray2(sortedMDArray);

void printMDArray2(int[,] sortedMDArray)
{
    for (int i = 0; i < sortedMDArray.GetLength(0); i++)
    {
        for (int j = 0; j < sortedMDArray.GetLength(1); j++)
        {
            Console.WriteLine(sortedMDArray[i, j]);
        }
        Console.WriteLine("--");
    }
}

int[,] convertListToArray(List<List<int>> listOfInts)
{
    int rows = listOfInts.Count;
    int columns = listOfInts[0].Count;
    int[,] myArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            myArray[i, j] = listOfInts[i][j];
        }
    }
    return myArray;
}

List<List<int>> convertArrayToList(int[,] twoDimensionalArray)
{
    List<List<int>> listOfInts = new List<List<int>>();
    int row = twoDimensionalArray.GetLength(0);
    int column = twoDimensionalArray.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        List<int> list = new List<int>();
        for (int j = 0; j < column; j++)
        {
            list.Add(twoDimensionalArray[i, j]);
        }
        listOfInts.Add(list);
    }
    return listOfInts;
}

//Rectangular Array Sorting -converting array to list approach - End



