int.TryParse(Console.ReadLine(), out int x);

for(int i = 1; i <= x; i++){
    if(x % i == 0){
        Console.WriteLine(i);
    }
}
