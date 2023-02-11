/* Составить частотный словарь элементов двумерного массива

Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Если набор данных - таблица

1, 2, 3
4, 6, 1
2, 1, 6

на выходе ожидаем получить

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза

*/

void PrintMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[] ChangeMatrixArray(int[,] matr)
{
    int len = (matr.GetLength(0)) * (matr.GetLength(1));
    int[] array = new int[len];
    int index=0;

    while (index < len)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
               array[index]= matr[i, j] ;
               index++;
            }
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write(String.Join(' ', array));
    Console.WriteLine();
}


void SelectSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

void ChastotniyMassiv(int[] array)
{
    int value = array[0];
    int quantity = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[0] == array[j])
        {
            value = array[j];
            quantity++;
        }
    }

    Console.WriteLine($"Значение {value} повторяется {quantity} раз");



    for (int i = 0; i < array.Length; i++)
    {
        if (value != array[i])
        {
            quantity = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    value = array[j];
                    quantity++;
                }
            }

            Console.WriteLine($"Значение {value} повторяется {quantity} раз");
        }


    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int m = ReadInt("Введите количество строк: ");
int n = ReadInt("Введите количество столбцов: ");

int[,] matrix = new int[m, n];
FillMatr(matrix);
PrintMatr(matrix);
Console.WriteLine();
int[] massiv = ChangeMatrixArray(matrix);
PrintArray(massiv);
SelectSort(massiv);
ChastotniyMassiv(massiv);
