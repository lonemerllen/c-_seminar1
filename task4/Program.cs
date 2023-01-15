Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num%2!=1){
    while(num>2){
        num=num-2;
        Console.Write($"{num} ");
    }
}
else{
    num=num-1;
    Console.Write($"{num} ");
    while(num>2){
        num=num-2;
        Console.Write($"{num} ");
    }
}