﻿char c = 'y'; 

while(c == 'y')
{
    Console.Clear();
    Console.WriteLine("BIN TO DEC CONVERTER\n");
    Console.WriteLine("Enter the binary number:");
    int bin = int.Parse(Console.ReadLine());
    double dec = 0;

    for (int i = 0; bin > 0; i++)
    {
        int rest = bin % 10;
        dec = dec + rest * Math.Pow(2, i);
        bin = bin / 10;
    }

    Console.WriteLine("\nDecimal value: {0}", dec);

    Console.WriteLine("\nTry another number? [Y] [N]");
    c = Console.ReadKey().KeyChar;
}
Console.Clear();
Console.WriteLine("                ████████████                  \r\n            ██              ██████            \r\n        ██    ████████████████    ██          \r\n      ██  ████████████████████████  ██        \r\n    ████████████████████████████████  ██      \r\n    ██  ██████████████████████████████████    \r\n  ██  ████████████████████████████████  ████  \r\n  ██  ██████████████████████████████████  ██  \r\n██  ████      ██    ████  ██        ████  ████\r\n██  ████  ██████    ████  ██  ████    ████  ██\r\n██  ████  ██████      ██  ██  ██████  ████  ██\r\n██  ████      ██  ██  ██  ██  ██████  ████  ██\r\n██  ████  ██████  ██  ██  ██  ██████  ████  ██\r\n██  ████  ██████  ████    ██  ████    ████  ██\r\n██  ████      ██  ████    ██        ████    ██\r\n  ██████████████████████████████████████  ██  \r\n  ██  ██████████████████████████████████  ██  \r\n  ████████████████████████████████████  ██    \r\n    ██  ████████████████████████████  ██      \r\n      ██  ████████████████████████  ████      \r\n        ██  ████████████████████  ████        \r\n          ██    ████████████    ████          \r\n            ████            ████              \r\n              ██████████████                  \r");