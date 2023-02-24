using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Vector
{
    private int z;
    private int x;
    private int c;
    public Vector(int z, int x, int c)
    {
        this.z = z;
        this.x = x;
        this.c = c;
    }
    public void VectorAddition(Vector obj)
    {
        z += obj.z;
        x += obj.x;
        c += obj.c;
    }
    public void VectorSubstraction(Vector obj)
    {
        z -= obj.z;
        x -= obj.x;
        c -= obj.c;
    }
    public void Multiplication(int num)
    {
        z *= num;
        x *= num;
        c *= num;
        Console.WriteLine($"Vector = {z + x + c}");
    }
}
struct Decimal
{
    private int num;
    public Decimal(int n)
    {
        num = n;
    }
    public void Bin()
    {
        string bin = Convert.ToString(num, 2);
        num = Convert.ToInt32(bin);
        Console.WriteLine($"\n{num}");
    }
    public void Oc()
    {
        string oc = Convert.ToString(num, 8);
        num = Convert.ToInt32(oc);
        Console.WriteLine($"\n{num}");
    }
    public void Hex()
    {
        string Hex = Convert.ToString(num, 16);
        num = Convert.ToInt32(Hex);
        Console.WriteLine($"\n{num}");
    }
}
namespace _16._02hm
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}