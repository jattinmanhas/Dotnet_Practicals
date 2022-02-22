class MergeSorting{
    public static IEnumerable<T> MergeSort<T>(IEnumerable<T> list) where T : IComparable
    {
        T[] items = list.ToArray();
        return InternalMergeSort(items);
    }

    public static T[] InternalMergeSort<T>(T[] items) where T : IComparable
    {
        int listLength = items.Length;

        if (listLength == 1)
        {
            return items;
        }

        int median = listLength / 2;

        T[] left = new T[median];
        T[] right = new T[listLength - median];
        Array.Copy(items, left, left.Length);
        Array.Copy(items, median, right, 0, right.Length);

        InternalMergeSort(left);
        InternalMergeSort(right);

        return Merge(items, left, right);
    }

    public static T[] Merge<T>(T[] items, T[] left, T[] right) where T : IComparable
    {
        int leftIndex = 0;
        int rightIndex = 0;

        int leftLength = left.Length;
        int rightLength = right.Length;
        int totalItems = leftLength + rightLength;

        for (int targetIndex = 0; targetIndex < totalItems; targetIndex++)
        {
            if(leftIndex >= leftLength)
            {
                items[targetIndex] = right[rightIndex];
                rightIndex++;
            }
            else if(rightIndex >= right.Length)
            {
                items[targetIndex] = left[leftIndex];
                leftIndex++;
            }
            else if(left[leftIndex].CompareTo(right[rightIndex]) < 0)
            {
                items[targetIndex] = left[leftIndex];
                leftIndex++;
            }
            else
            {
                items[targetIndex] = right[rightIndex];
                rightIndex++;
            }
        }

        return items;
    }

    public static void PrintList<T>(IEnumerable<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}