public class SortingAlgorithm
{
    public void  SelectionSort(int[] input)
    {
        for (int i = 0; i < input.Length -1; i++)
        {
            for (int j = i+ 1; j < input.Length; j++)
            {
                if (input[i] > input[j]){
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;

                }
            }

        }

    }
}


