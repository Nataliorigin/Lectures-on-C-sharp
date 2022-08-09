int[] array = { 1, 14, 47, 87, 96, 4, 74, 12, 74, 6 };

int n = array.Length;
int find = 74;
int index = 0;
while (index < n)
{
	if (array[index] == find) {
		Console.WriteLine(index);
		break;
	}
	index++;
}
