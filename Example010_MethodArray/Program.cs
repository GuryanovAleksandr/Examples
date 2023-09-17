int[] array = {16, 82, 43, 64, 87, 76, 52, 73, 87};
int n = array.Length;
int find = 87;
int index = 0;
while (index < n)
{
    if (array[index] == find)
        {
            Console.WriteLine(index);
            break;
        }
    // index = index + 1;
    index++;
}