double b1 = Convert.ToDouble(Console.ReadLine()),
       k1 = Convert.ToDouble(Console.ReadLine()),
       b2 = Convert.ToDouble(Console.ReadLine()),
       k2 = Convert.ToDouble(Console.ReadLine()),
        x = (b2 - b1) / (k1 - k2),
        y = (k1 * ((b2 - b1) / (k1 - k2))) + b1;
Console.WriteLine($"{x}, {y}");