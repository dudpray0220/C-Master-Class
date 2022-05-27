class Sample
{
    static void Main()
    {
        // 초기화의 3가지 방법
        sbyte a = sbyte.MaxValue;
        sbyte b = 100; 
        sbyte c = default(sbyte);

        byte d = byte.MaxValue;
        short e = short.MaxValue;
        ushort f = ushort.MaxValue;
        int g = int.MaxValue;
        uint h = uint.MaxValue;
        long l = long.MaxValue;
        ulong r = ulong.MaxValue;

        float j = float.MaxValue;
        double p = double.MaxValue;
        decimal k = decimal.MaxValue;
        char y = 'A';
        string z = "abc";
        bool o = default(bool);

        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g);
        System.Console.WriteLine(h);
        System.Console.WriteLine(l);
        System.Console.WriteLine(r);
        System.Console.WriteLine(j);
        System.Console.WriteLine(p);
        System.Console.WriteLine(k);
        System.Console.WriteLine(y);
        System.Console.WriteLine(z);
        System.Console.WriteLine(o);

        System.Console.ReadKey();
    }
}