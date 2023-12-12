public class SortingAlgorithm
{
    public void SelectionSort(int[] input)
    {
        for (int i = 0; i < input.Length - 1; i++)
        {
            int index_sv = i;
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[index_sv] > input[j])
                {
                    index_sv = j;
                }
            }
            int temp = input[i];
            input[i] = input[index_sv];
            input[index_sv] = temp;
        }
    }

    public void BubleSort(int[] input)
    {
        for (int i = 0; i < input.Length - 1; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] > input[j])
                {
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }
            }
       }

    }
}


