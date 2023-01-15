Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int max = num1, min = num1;
if(num1>num2){
    max = num1;
    min = num2;
}
else{
    max = num2;
    min = num1;
}
Console.WriteLine($"max = {max}, min = {min}");