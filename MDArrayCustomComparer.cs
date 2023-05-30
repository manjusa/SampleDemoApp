public class MDArrayCustomComparer : IComparer<int>
{
    int[,] arrayToBeSorted;
    public MDArrayCustomComparer(int[,] twoDimArray)
    {
        arrayToBeSorted = twoDimArray;
    }

    public int Compare(int x, int y)
    {
        return arrayToBeSorted[x, 0].CompareTo(arrayToBeSorted[y, 0]);
    }
}