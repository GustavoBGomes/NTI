
int n_1 = 1;
int n_2 = 0;
int f = 0;

Console.WriteLine("Sequência de Fibonacci");

for (var i = 1; i <= 20; i++) {

   f = n_1 + n_2;
   n_2 = n_1;
   n_1 = f;

    Console.WriteLine($"A Sequência é: {f}");

}

Console.ReadKey();