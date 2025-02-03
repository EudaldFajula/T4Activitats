using System;
using System.Collections;
using T4Activitats.Act1;
namespace Activitats
{
    public class Act
    {
        public static void Main()
        {
            //Act1
            //Parella<string, int> parellaTest1 = new Parella<string, int>("Hola", 2);
            //parellaTest1.MostrarValors();
            //Parella<double, bool> parellaTest2 = new Parella<double, bool>(3.4, true);
            //parellaTest2.MostrarValors();
            //Act2
            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine("Cuants valors vols?");
            //int longitud = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < longitud; i++)
            //{
            //    Console.WriteLine("Escriu valor: ");
            //    arrayList.Add(Console.ReadLine());
            //}
            //foreach (var i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}
            //Act 3
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            Console.WriteLine("Cuants valors vols?");
            int longitud = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < longitud + 1; i++)
            {
                Console.WriteLine("Escriu quines edats vols introduir?");
                dictionary.Add($"Alumne {i}:", Convert.ToInt32(Console.ReadLine()));
            }
            foreach (var items in dictionary)
            {
                Console.WriteLine($"{items.Key} {items.Value}");
            }
        }
    }
}