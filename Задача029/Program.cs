// Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void zapolnMassiva(int[] numbers)// метод заполнения массива случайными числами наименование 
{
    int length = numbers.Length;// Длинна массива
    int i = 0;// позиция индекса с нуля
    while (i < length)// условие
    {
        numbers[i] = new Random().Next(1, 20);//обращение к number и присваиваем случ значение
        i++;
    }
}

void showResult(int[] numb)// метод который будет печатать массив (numb)
{
    int index = numb.Length;// кол-во элементов
    int tek = 0;// position текущ позиция (index)
    while (tek < index)// условие
    {
        System.Console.WriteLine(numb[tek]);// выводим значение текущего элемента
        tek++;
    }
}

int[] numbers = new int[8];//название массива"numbers" = "новый массив[8 элементов]"

zapolnMassiva(numbers);
showResult(numbers);