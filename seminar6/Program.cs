// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
int[] ReverseArray(int[] array)
{
    int LastIndex = array.Length - 1;
    int size = array.Length;
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    int i = 0, j = array.Length - 1;

    /*
    while(i < j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;

    }
*/
    return array;
}

int[] myArray = {3, 5, 1, 8, 2, 9, 4};

myArray = ReverseArray(myArray);

for(int i = 0; i < myArray.Length; i++)
    ConsoleWrite(myArray[i] + " ");
    