int[] ArrMaxMin(int[] arr)
{
	for (int i = 0; i < arr.Length - 1; i++)
	{
		int maxPosition = i;
		for (int j = i + 1; j < arr.Length; j++)
		{
			if (arr[j] > arr[maxPosition]) maxPosition = j;
		}
		int temp = arr[i];
		arr[i] = arr[maxPosition];
		arr[maxPosition] = temp;
	}
	return arr;
}

int[] arr = { 3, 3, 7, 1, 45, 32, 89, 15 };

Console.Write(string.Join(", ", ArrMaxMin(arr)));