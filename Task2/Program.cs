// раскрасить черно-белое изображение
// метод который будет выводить эту картинку

int[,] pic = new int[,];

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++) 
    {
        for (int j = 0; j < image.GetLength(1); j++) 
        {
            //Console.Write($"{image[i, j]} "); в момент вывода проделаем такую операцию: если текущий элемент совпадает с ноликом то в этом случае будем печатать пробел
            if (image[i, j] == 0) Console.WriteLine($" ");
            else Console.WriteLine($"+");
        }
        System.Console.WriteLine();
    }
}

// метод который будет закрашивать картинку

void FillImage(int row, int col) // дальше указываем условие: если текущий пиксель равен нулю(т.е он не закрашен)
{
    if (pic[row, col] == 0) // в этом случаем мы будем его красить
    {
          pic[row, col] = 1;
          FillImage(row - 1, col);
          FillImage(row, col - 1);
          FillImage(row + 1, col);
          FillImage(row, col + 1);
    }
}


PrintImage(pic);
FillImage(13, 13); // укажем случайную точку находящуюся внутри нашего изображения
FillImage(pic);