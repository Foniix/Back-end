namespace Task2_3
{
    static class ArrayExtension
    {
        public static void SortAscending(this int[] arr, int first, int last)
        {
            while (true)
            {
                if (first < last)
                {
                    var middle = arr[(first + last) / 2];
                    int i = first, j = last;
                    while (i <= j)
                    {
                        while (i <= last && arr[i] < middle) ++i;
                        while (j >= first && arr[j] > middle) --j;
                        if (i > j) continue;
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        ++i;
                        --j;
                    }

                    if (i < last) SortAscending(arr, i, last);
                    if (j > first)
                    {
                        last = j;
                        continue;
                    }
                }

                break;
            }
        }

        public static void SortByDecreasing(this int[] arr, int first, int last)
        {
            while (true)
            {
                if (first < last)
                {
                    var middle = arr[(first + last) / 2];
                    int i = first, j = last;
                    while (i <= j)
                    {
                        while (i <= last && arr[i] > middle) ++i;
                        while (j >= first && arr[j] < middle) --j;
                        if (i > j) continue;
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        ++i;
                        --j;
                    }

                    if (i < last) SortByDecreasing(arr, i, last);
                    if (j > first)
                    {
                        last = j;
                        continue;
                    }
                }

                break;
            }
        }

        public static void SortByBool(this int[] arr, int first, int last, bool way)
        {
            if (way)
                SortAscending(arr, first, last);
            else
            {
                SortByDecreasing(arr, first, last);
            }
        }

    }
}
