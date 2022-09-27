Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int x_tmp, x2 = 0; x_tmp = x;       
while (x_tmp > 0)
    {
     x2 *= 10;
     x2 += x_tmp % 10;
     x_tmp /= 10;
    }
if (x == x2) 
    {
        Console.WriteLine("палиндром");
    }
else
    {
        Console.WriteLine("не палиндром");
    }
 