using System;
using System.Collections;
using System.Collections.Generic;
using T4Activitats.Act1;
using T4Activitats.Act12;
using T4Activitats.Act13;
namespace Activitats
{
    public class Act
    {
        public static void Main()
        {
            /*
            
            //Act1
            Parella<string, int> parellaTest1 = new Parella<string, int>("Hola", 2);
            parellaTest1.MostrarValors();
            Parella<double, bool> parellaTest2 = new Parella<double, bool>(3.4, true);
            parellaTest2.MostrarValors();
            
            //Act2
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("Cuants valors vols?");
            int longitudDos = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < longitudDos; i++)
            {
                Console.WriteLine("Escriu valor: ");
                arrayList.Add(Console.ReadLine());
            }
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            
            //Act 3
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            Console.WriteLine("Cuants valors vols?");
            int longitudTres = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < longitudTres + 1; i++)
            {
                Console.WriteLine("Escriu quina edat vols introduir?");
                dictionary.Add($"Alumne {i}:", Convert.ToInt32(Console.ReadLine()));
            }
            foreach (var items in dictionary)
            {
                Console.WriteLine($"{items.Key} {items.Value}");
            }
            
            //Act 4
            List<string> list = new List<string>();
            Console.WriteLine("Quants valors vols?");
            int longitudQuatre = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < longitudQuatre; i++)
            {
               Console.WriteLine("Escriu quin nom vols introduir:");
                list.Add(Console.ReadLine());
            }
            Console.WriteLine("Llista no ordenada");
            //LLista sense ordenar
            foreach (string items in list)
            {
                Console.WriteLine(items);
            }
            list.Sort();
            Console.WriteLine("Llista ordenada");
            //Llista ordenada
            foreach (string items in list)
            {
               Console.WriteLine(items);
            }
            
            //Act 5
            List<int> listNum = new List<int>();
            Console.WriteLine("Cuants valors vols?");
            int longitudCinc = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < longitudCinc; i++)
            {
                Console.WriteLine("Quin valor vols introduir?");
                listNum.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (int num in listNum)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
            
            //Act 6
            Console.WriteLine("Introdueix una data format -> YYYY-MM-DD:");
            DateTime data = DateTime.Parse(Console.ReadLine());
            DateTime avui = DateTime.Now;
            TimeSpan diferencia = data.Subtract(avui);
            Console.WriteLine($"Falten {diferencia.Days} dies");
            
            //Act 7
            ArrayList arrayList = new ArrayList() { "Maria", "Joan", "Anna", 42, true };
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            //Esborrar el 43
            arrayList.Remove(42);
            //Esborrar el true
            arrayList.Remove(true);
            //Afegir el Pere
            arrayList.Insert(2, "Pere");
            //Comprovar si esta la Anna
            Console.WriteLine("Comprovar si esta l'anna");
            Console.WriteLine(arrayList.Contains("Anna"));
            //Convertir l'array a un string[]
            string[] arrayString = new string[arrayList.Count]; 
            arrayList.CopyTo(arrayString);
            Console.WriteLine("Array now tipus string");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            
            //Act 8
            List<int> listInts = new List<int>() { 5,10,15,20,25 };
            //Afegir el 30 al final de la llista
            listInts.Add(30);
            //Afegir el 7 al principi
            listInts.Insert(0, 7);
            //Eliminar el numero 15
            listInts.Remove(15);
            //Ordernar la llista de manera descendet
            listInts.OrderByDescending(n => n).ToList();
            //Filtrar nombres parells
            var list = listInts.Where(n => n % 2 == 0).ToList();
            //Printar
            Console.WriteLine(string.Join(" | ", list));
            
            //Act9
            Dictionary<string, int> dictActNine = new Dictionary<string, int>();
            //Afegir dades al diccionari
            dictActNine.Add("Marc", 21);
            dictActNine.Add("Laura", 29);
            dictActNine.Add("Pau", 22);
            //Printar dades diccionari
            foreach(var variable in  dictActNine)
            {
                Console.WriteLine($"Nom: {variable.Key}, Edat: {variable.Value}");
            }
            //Preguntar usuari si existeix el nom i ensenyar la seva edat
            Console.WriteLine("Quin nom vols trobar al diccionari?");
            string nomBuscar = Console.ReadLine();
            Console.WriteLine(dictActNine.ContainsKey(nomBuscar) ? $"El nom esta al diccionari\nLa seva edat es:{dictActNine[nomBuscar]}" : "El nom no esta al diccionari.");
            //Esborrar Laura del diccionari
            dictActNine.Remove("Laura");
            //Iterar totes les entrades i mostrarles per pantalla
            foreach (var variable in dictActNine)
            {
                Console.WriteLine($"Nom: {variable.Key}, Edat: {variable.Value}");
            }
            
            //Act 10
            Console.WriteLine("Escriu la primera data amb format -> YYYY-MM-DD");
            DateTime primeraData = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Escriu la segona data amb format -> YYYY-MM-DD");
            DateTime segonaData = DateTime.Parse(Console.ReadLine());
            if (CompareDates(primeraData, segonaData) > 0)
            {
                Console.WriteLine("La segona data es posterior a la primera data");
            }else if (CompareDates(primeraData, segonaData) == 0)
            {
                Console.WriteLine("Les datas son iguals");
            }
            else
            {
                Console.WriteLine("La segona data es abans de la primera data");
            }
            
            //Act 11
            Console.WriteLine(DateToday());
            
            //Act 13
            List<Employee> employeesList = new List<Employee>() { new Employee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(2126, 12, 12, 12, 12, 12)), new Employee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(2252, 12, 12, 12, 12, 12)), new Employee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(3123, 12, 12, 12, 12, 12)), new Employee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(1216, 12, 12, 12, 12, 12)), new Employee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(1999, 12, 12, 12, 12, 12)) };
            employeesList.OrderByDescending(e => e.GetHireDate());
            List<SalesEmployee> salesEmployeesList = new List<SalesEmployee>() { new SalesEmployee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(2116, 12, 12, 12, 12, 12), 564), new SalesEmployee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(1111, 12, 12, 12, 12, 12), 564), new SalesEmployee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(1114, 12, 12, 12, 12, 12), 564), new SalesEmployee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(0573, 12, 12, 12, 12, 12), 564), new SalesEmployee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(1765, 12, 12, 12, 12, 12), 564),};
            salesEmployeesList.OrderByDescending (e => e.GetHireDate());
            employeesList.ForEach(e => Console.WriteLine(e.ToString()));
            salesEmployeesList.ForEach(e => Console.WriteLine(e.ToString()));
            */
            //Act 14
            int totalNum = 0;
            List<int> numList = new List<int>() {1,2,3,5,7,8,4,23,23,467,5 };
            numList.ForEach(num => { totalNum += num; });
            Console.WriteLine(totalNum);
        }
        //Act 10
        public static int CompareDates(DateTime primeraData, DateTime segonaData)
        {
            return segonaData.CompareTo(primeraData);
        }
        //Act 11
        public static DayOfWeek DateToday() => DateTime.Today.DayOfWeek;
    }
}