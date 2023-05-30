public class JaggedArrayCustomComparer : IComparer<int[]>
{
    private int i;

    public JaggedArrayCustomComparer(int i)
    {
        this.i = i;
    }
    public JaggedArrayCustomComparer()
    {

    }

    public int Compare(int[]? x, int[]? y)
    {
        int[] arr1 = x;
        int[] arr2 = y;
        int result = arr1.Length.CompareTo(arr2.Length);
        if (result == 0)
        {
            result = arr1[i].CompareTo(arr2[i]);
        }
        return result;
    }
}