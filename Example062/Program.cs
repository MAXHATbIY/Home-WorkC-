// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] matrix = new int[rows, columns];
if (rows == 1 && columns == 1) matrix[0,0] = 1;   // учитываем исключительный случай матрицы 1х1
else matrix = GetSpiralArray(rows, columns);
PrintArray(matrix);

int[,] GetSpiralArray(int row, int col)
{
    int[,] spiralArray = new int[rows, columns];
    int i = 0;   // стратовая позиция рядов
    int j = 0;   // стратовая позиция столбцов
    int step = 1;   // шаг для передвижения по матрице
    int num = 1;   // число, с которого начинается заполнение
    
    while (num <= rows * columns) 
    {
        while (j + step >= 0 && j + step < columns)
        {
            if (spiralArray[i, j] == 0)
            {
                spiralArray[i, j] = num;
                num++; 
            }         
            if (num > rows * columns ||  spiralArray[i, j + step] != 0) break;   // условия для досрочного выхода из цикла - следующая ячейка заполнена или закончились пустые ячейки
            j += step;
        }
        
        while (i + step >= 0 && i + step < rows)
        {           
            if (spiralArray[i, j] == 0)
            {
                spiralArray[i, j] = num;
                num++;
            }          
            if (num > rows * columns || spiralArray[i + step, j] != 0) break;   // условия для досрочного выхода из цикла - следующая ячейка заполнена или закончились пустые ячейки                
            i += step;
        }
        step *= -1;   // в конце итерации внешнего цикла меняем напраление движения
    }    
    return spiralArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
             Console.Write($"{inArray[i, j]} ");
        }
         Console.WriteLine();
     }
}


