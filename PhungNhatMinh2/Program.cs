using System;
using System.Collections;
using YamlDotNet.Core;

class Program
{
    public interface IStudent
    {

        void Print();
    }
    class Student : IStudent
    {


        int StuId { get; set; }
        string StuName { get; set; }
        string StuGender { get; set; }
        int StuAge { get; set; }
        string StuClass { get; set; }
        float StuAvgMark { get; set; }
        List<float> marklist = new List<float>(3);

        public float Calmark
        {
            return (marklist[1]+marklist[2]+marklist[0])/3;
        }
    public void Print()
    {
        Console.WriteLine(StuId + " " + StuName + " " + StuGender + " " + StuClass + " " + StuAge + " " + (mark1 + mark2 + mark3) / 3);

    }


}
public static void main(string[] args)
{
    Console.WriteLine("1.Insert new Student");
    Console.WriteLine("2.Display all the student list...");
    Console.WriteLine("3.Caculator avenrage mark...");
    Console.WriteLine("4.Exit");
    Console.WriteLine("option:");
    int chon = Convert.ToInt32(Console.ReadLine());
    while (chon > 4 && chon < 0)
    {

        Console.WriteLine("1.Insert new Student");
        Console.WriteLine("2.Display all the student list...");
        Console.WriteLine("3.Caculator avenrage mark...");
        Console.WriteLine("4.Exit");
        Console.WriteLine("option:");
        Console.WriteLine("option:");
        int chon = Convert.ToInt32(Console.ReadLine());
        switch (chon)
        {
            case 1: Console.WriteLine();
            case 2: Console.WriteLine();
            case 3: Console.WriteLine();
            case 4: break;
        }
    }
}

