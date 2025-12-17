namespace FuncTask4
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            #region task 1
            //int x = 200;
            //int y = 40;

            //MathOperation operation;

            //operation = MathOperations.Add;
            //Console.WriteLine($"add: {operation(x, y)}");

            //operation = MathOperations.Subtract;
            //Console.WriteLine($"cixma: {operation(x, y)}");

            //operation = MathOperations.Multiply;
            //Console.WriteLine($"vurma: {operation(x, y)}");

            //operation = MathOperations.Divide;
            //Console.WriteLine($"bolme: {operation(x, y)}");
            #endregion

            #region task 2
            Action<string> salam;

            salam = Task2.SalamAz;
            salam("Natig");

            salam = Task2.SalamEn;
            salam("Natig");

            salam = Task2.SalamTr;
            salam("Natig");

            #endregion

            #region task 3
            //Func<int, bool> isEven = number => number % 2 == 0;

            //Func<int, bool> isPositive = number => number > 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"eded: {i}, Cutdur: {isEven(i)}, Musbetdir: {isPositive(i)}");
            //}
            #endregion

            #region task 4
            //List<Telebe> telebeler = new List<Telebe>
            //    {
            //    new Telebe { Name = "Gulnare",    Price = 99, Age = 24},
            //    new Telebe { Name = "Ferid",  Price = 92, Age = 22 },
            //    new Telebe { Name = "Elbrus",  Price = 60, Age = 21 },
            //    new Telebe { Name = "Emil H",   Price = 90, Age = 40 },
            //    new Telebe { Name = "Nezrin",  Price = 45, Age = 29 },
            //    new Telebe { Name = "Murad",  Price = 68, Age = 22},
            //    new Telebe { Name = "Natig", Price = 95, Age = 18 }
            //    };

            //Predicate<Telebe> qiymeti70 = x => x.Price > 70;
            //Predicate<Telebe> yasi20 = x => x.Age < 20;
            //Predicate<Telebe> adiA = x => x.Name.StartsWith("A");

            //List<Telebe> Qiymet = telebeler.FindAll(qiymeti70);
            //List<Telebe> Yas = telebeler.FindAll(yasi20);
            //List<Telebe> Ad = telebeler.FindAll(adiA);

            //Func<Telebe, string> Telebe = x =>
            //    $"Ad: {x.Name}, Qiymet: {x.Price}, Yas: {x.Age}";

            //Action<List<Telebe>> telebee = list =>
            //{
            //    foreach (var x in list)
            //    {
            //        Console.WriteLine(Telebe(x));
            //    }
            //    Console.WriteLine("");
            //};

            //Console.WriteLine($"Qiymeti 70-den yuxari olanlar:");
            //telebee(Qiymet);

            //Console.WriteLine("Yasi 20-den kicik olanlar:");
            //telebee(Yas);

            //Console.WriteLine("Adi 'A' ilee baslayanlar:");
            //telebee(Ad);
        #endregion
        }
    }
}

