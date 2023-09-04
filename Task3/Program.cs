// метод который будет принимать число, факториал которого надо вычислить

/*int Factorial (int n)
{
    if(n == 1) return 1; // 1! == 1 ( также отметим, что 0! == 1)
    else return n * Factorial(n-1);
}

System.Console.WriteLine(Factorial(3)); // 3! = 1*2*3= 6*/

// числа фибоначчи
int Fibonacci(int n)
{
if(n == 1 || n == 2) return 1;
else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 10; i++)
{
Console.WriteLine(Fibonacci(i));
}
