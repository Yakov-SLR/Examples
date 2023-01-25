Console.Clear(); //Очищаем консоль
//Console.SetCursorPosition(10, 4); //Устанавливаем отступ от левого края 10 символов, от верхнего края 4 символа
//Console.WriteLine("+"); //Задаём символ, которым будем рисовать

int xa = 40, ya = 1;
int xb = 1, yb = 30;
int xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); // Задаём случайный интервал [0;3] 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; //Моно также записывать count++ (если увеличиваем на 1) или count +=1
}
