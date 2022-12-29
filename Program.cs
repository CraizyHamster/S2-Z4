//Наишите программу которая принимает на вход точки(x и у)
// причем х неравен 0 и у не равен 0  и выдает номер четсверти плоскости , в которой он находится
/*void SearchSquad(int x, int y){
    if(x==0 || y==0)
        Console.WriteLine("Error");
    else if (x>0 && y>0)
        Console.WriteLine("Точка находится в первой четверьт");
     else if (x>0 && y<0)   
        Console.WriteLine("Точка находится во четвертая четверти");
     else if (x<0 && y<0)
        Console.WriteLine("Точка находится в вторая четверти");
     else 
        Console.WriteLine("Точка находится в третьей четверти");
}
Console.WriteLine("Введите координату x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y:");
int y = Convert.ToInt32(Console.ReadLine());

SearchSquad(x , y);
*/

/* Напишите программу которая по заданному номеру четверти показывает 
диапазон возможных координат точек в этой четверти (х и у)*/
 /*
 void SearchCoordinata(int number){
    if(number ==1) Console.WriteLine("X > 0 and y > 0");
    else if(number ==2) Console.WriteLine("X < 0 and y > 0");
    else if(number ==3) Console.WriteLine("X < 0 and y > 0");
    else if(number ==4) Console.WriteLine("X > 0 and y < 0");
    else Console.WriteLine("Error");
 }

Console.WriteLine("Введите номер четверти - ");
int number = Convert.ToInt32(Console.ReadLine());
SearchCoordinata(number);
*/

// Напишите программу которая на вход принимает число N и выдает тыблицу квадратов чисел от 1 до N
/* void Table (int number){
    int number1 = 1;
        while(number1 <= number)
        {
            System.Console.Write(number1*number1 + " ");
            number1++;
        }
 }
System.Console.WriteLine("Введите число");
int user = Convert.ToInt32(Console.ReadLine());
Table(user);
*/

//Напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними в 2d пространстве
// AB = корень (xb - xa)2 + (yb - ya)2

   
/*void Dist (int x, int x1, int y, int y1, int z, int z1){
   double d = Math.Sqrt(Math.Pow((x1-x),2)+Math.Pow((y1-y),2)+Math.Pow((z1-z),2));
   Console.WriteLine($"Расстояние:{Math.Round(d,2)}");
}

Console.WriteLine("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Dist(x, x1, y, y1, z, z1);
*/








//                                        Домашка 21

/*void Dist (int x, int x1, int y, int y1, int z, int z1){
   double d = Math.Sqrt(Math.Pow((x1-x),2)+Math.Pow((y1-y),2)+Math.Pow((z1-z),2));
   Console.WriteLine($"Расстояние:{Math.Round(d,2)}");
}

Console.WriteLine("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Dist(x, x1, y, y1, z, z1);
*/


//                                              Задача 23

/* void Table (int number){
    int number1 = 1;
        while(number1 <= number)
        {
            System.Console.Write(number1*number1*number1 + " ");
            number1++;
        }
 }
System.Console.WriteLine("Введите число");
int user = Convert.ToInt32(Console.ReadLine());
Table(user);
*/ 



 
