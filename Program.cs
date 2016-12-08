using System;
using System.Reflection;

namespace germ13{
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        var table = new TheTable();
        var k = table.getProperty(3);
        foreach(var i in k){
            Console.WriteLine(i);
        }

        Console.ReadKey();
    }
}








}