using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            var abonetek = new List<Abonet>();
            using var sr = new StreamReader(
                path: @"..\..\..\src\abi.txt",
                encoding: Encoding.UTF8

                );
            
            
            while (!sr.EndOfStream)
            {
                abonetek.Add(new Abonet(sr.ReadLine()));
            }
            foreach (var x in abonetek)
            {
                
                Console.WriteLine($"{x.nev}  {x.zsir}  {x.szenhidrat}");

            }


            Console.WriteLine();
            double legkisebbzsir = abonetek.Min(abonetek => abonetek.zsir);
            foreach (var x in abonetek)
            {
                
                if (x.zsir == legkisebbzsir)
                {
                    Console.WriteLine(x.nev);
                }
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
