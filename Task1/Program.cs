string[,] table = new string[2, 5]; // Здесь задан массив страк(таблица из строк) . тип данных; массив- запятая указывает на размерность -указание к тому , что у нас будет 2 размерности; наименование массива
// после этого new string и в [] указываем сколько строк и столбцов нам нужно

int[,] matrix = new int[2, 5]; // Задана прямоугольная таблица чисел( обычно называют матрицей) 2- кол-вл строк, 5 - кол-во столбцов

// чтобы обратиться к нужному элементу массива. имя массива, в скобках индекс строки и индекс столбца. после этого как и ранее можно работать как с обычной переменной
table[1, 2] = "слово"; 

// индексы как строк так и столбцов меняются от нуля
string[,] table = new string[2, 5];



// table[0, 0], table[0, 1], table[0, 2], table[0, 3], table[0, 4] 4- максимальный индекс столбца
// table[1, 0], table[1, 1], table[1, 2], table[1, 3], table[1, 4] 4- максимальный индекс строки
// String.Empty -инициализация для строк

// используе цикл в цикле чтобы распечатать этот массив

/*for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++) 
    {
     Console.WriteLine($"{table[rows, columns]}");
    }
}*/

int[,] matrix = new int[3, 4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
       Console.Write($"{matrix[i, j]} "); 
    }
    System.Console.WriteLine();
}

// новый функционал чтобы получить количество строк/столбцов
int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++) // 0 обозначает количество строк(для нас это 3)
{
    for (int j = 0; j < matrix.GetLength(1); j++) // 1 обозначает количество столбцов(для нас это 4)
    {
       Console.Write($"{matrix[i, j]} "); 
    }
    System.Console.WriteLine();
}

// метод который будет отдельно печатать двумерную матрицу на экран и заполнять ее числами


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
        Console.Write($"{matr[i, j]} "); 
        }
        System.Console.WriteLine();
    }
}

// метод который заполняет нашу матрицу случайными числами

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}


int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();// сделаем пустую строку между нулями и заполненной матрицей
PrintArray(matrix);