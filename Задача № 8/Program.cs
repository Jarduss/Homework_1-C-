Console.WriteLine("Введите число - ");
int n = int.Parse(Console.ReadLine());
if (n > 0)
for (int i = 1; i <= n; i++){
    if (i % 2 == 0){
        Console.WriteLine(i);
        }
    }
if (n < 0) 
for (int i = 1; i >= n; i--){
if (i % 2 == 0){
    Console.WriteLine(i);
        }   
    }