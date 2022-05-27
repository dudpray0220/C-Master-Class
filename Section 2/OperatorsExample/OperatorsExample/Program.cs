class Sample
{
    static void Main()
    {
        // 산술 연산자
        decimal a = 10M;
        decimal b = 3M;
        decimal c = a + b;
        decimal d = a - b; 
        decimal e = a * b;
        decimal f = a / b; 
        decimal g = a % b;

        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g + "\n");


        // 할당 연산자
        a += 20M;
        System.Console.WriteLine(a);
        a -= 20M;
        System.Console.WriteLine(a);
        a *= 3M;
        System.Console.WriteLine(a);
        a /= 3M;
        System.Console.WriteLine(a);
        a %= 3M;
        System.Console.WriteLine(a);


        // 증감 연산자
        a = 10M;
        System.Console.WriteLine();
        System.Console.WriteLine(++a); // Output : 11
        System.Console.WriteLine(a++); // Output : 11
        System.Console.WriteLine(a); // Output : 12
        System.Console.WriteLine(--a); // Output : 11
        System.Console.WriteLine(a--); // Output : 11
        System.Console.WriteLine(a); // Output : 10


        // 비교 연산자 (항상 bool 값을 return)
        System.Console.WriteLine();
        bool b1 = a == 10;
        System.Console.WriteLine(b1);
        bool b2 = a != 10;
        System.Console.WriteLine(b2);
        bool b3 = a < 10;
        System.Console.WriteLine(b3);
        bool b4 = a > 10;
        System.Console.WriteLine(b4);
        bool b5 = a <= 10;
        System.Console.WriteLine(b5);
        bool b6 = a >= 10;
        System.Console.WriteLine(b6);


        // 논리 연산자 (항상 bool 값을 return)
        System.Console.WriteLine();
        bool b7 = a == 10 & b == 10;
        System.Console.WriteLine(b7);
        bool b8 = a == 10 && b == 10;
        System.Console.WriteLine(b8);
        bool b9 = a == 10 | b == 10;
        System.Console.WriteLine(b9);
        bool b10 = a == 10 || b == 10;
        System.Console.WriteLine(b10);
        bool b11 = !(a == 10);
        System.Console.WriteLine(b11);
        bool b12 = a == 10 ^ b == 10;
        System.Console.WriteLine(b12);


        // 연결 연산자
        System.Console.WriteLine();
        string name = "Bae";
        int age = 20;
        string message = "Hey " + name + ", your age is " + age;
        System.Console.WriteLine(message);


        // 삼항 연산자
        System.Console.WriteLine();
        string title = (age < 13) ? "Child" : (13 <= age && age < 20) ? "Teenager" : "Adult";
        System.Console.WriteLine(title);


        // 연산자 우선순위
        System.Console.WriteLine();
        double z = 10 + 4 * 30 / 10;
        System.Console.WriteLine(z);

        System.Console.ReadKey();
    }
}