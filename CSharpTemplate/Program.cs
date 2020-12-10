using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //var cin = new Scanner(new StreamReader(Console.OpenStandardInput()));
        var cin = new Scanner(new StreamReader("input.txt"));
        Action<dynamic> cout = (s) => Console.Write(s);
        Action<dynamic> coutline = (s) => Console.WriteLine(s);
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false });

        //input

        var sw = new Stopwatch(); sw.Start();
        //stuff
        sw.Stop();
        //coutline(sw.ElapsedMilliseconds);

        Console.Out.Flush();
    }
}

class Scanner
{
    private StreamReader _input;
    private string[] _line;
    private int _index;
    private const char Separator = ' ';

    public Scanner(StreamReader input)
    {
        _input = input;
        _line = new string[0];
        _index = 0;
    }

    public string Next()
    {
        if (_index >= _line.Length)
        {
            string s;
            do
            {
                s = _input.ReadLine();
            } while (s.Length == 0);

            _line = s.Split(Separator);
            _index = 0;
        }

        return _line[_index++];
    }

    public string ReadLine()
    {
        _index = _line.Length;
        return _input.ReadLine();
    }

    public int NextInt() => int.Parse(Next());
    public long NextLong() => long.Parse(Next());
    public double NextDouble() => double.Parse(Next());
    public decimal NextDecimal() => decimal.Parse(Next());
    public char NextChar() => Next()[0];
    public char[] NextCharArray() => Next().ToCharArray();

    public string[] Array()
    {
        string s = _input.ReadLine();
        _line = s.Length == 0 ? new string[0] : s.Split(Separator);
        _index = _line.Length;
        return _line;
    }

    public int[] IntArray() => Array().Select(int.Parse).ToArray();
    public long[] LongArray() => Array().Select(long.Parse).ToArray();
    public double[] DoubleArray() => Array().Select(double.Parse).ToArray();
    public decimal[] DecimalArray() => Array().Select(decimal.Parse).ToArray();
}
