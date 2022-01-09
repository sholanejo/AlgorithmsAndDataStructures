namespace AlgorithmsAndDataStructures
{
    public static class SelectionSort
    {
        //public static int SmallestNumber(int[] intList)
        //{
        //    int indexNum = intList[0];
        //    for (int i = 1; i < intList.Length; i++)
        //    {
        //        if (intList[i] < indexNum)
        //        {
        //            indexNum = intList[i];
        //        }

        //    }
        //    return indexNum;
        //}
        //public static List<int> SelectSort(int[] intList)
        //{
        //    int[] sortedList = { };
        //    for (int i = 0; i < intList.Length; i++)
        //    {
        //        sortedList.(SmallestNumber(intList));

        //    }

        //    return sortedList;
        //}

        public static void Sort(int[] arr)
        {
            int i, j, min;
            for (i = 0; i < arr.Length; i++)
            {
                min = i;
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;
                        Swap(ref arr[i], ref arr[min]);
                    }
                }
            }
        }

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}