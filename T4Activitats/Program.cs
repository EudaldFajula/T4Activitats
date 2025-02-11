using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using T4Activitats.Act1;
using T4Activitats.Act12;
using T4Activitats.Act13;
using static Activitats.Act;
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
            arrayList.Insert(1, "Pere");
            //Comprovar si esta la Anna
            Console.WriteLine("Comprovar si esta l'anna");
            Console.WriteLine(arrayList.Contains("Anna"));
            //Convertir l'array a un string[]
            string[] arrayString = new string[arrayList.Count]; 
            arrayList.CopyTo(arrayString);
            Console.WriteLine("Array es tipus string");
            foreach (string item in arrayString)
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
            
            //Act 14
            int totalNum = 0;
            List<int> numList = new List<int>() {1,2,3,5,7,8,4,23,23,467,5 };
            numList.Sum(num => totalNum += num);
            Console.WriteLine(totalNum);
            
            //Act 15
            List<int> numList = new List<int>() { 1, 2, 3, 5, 7, 8, 4, 23, 23, 467, 5 };
            numList.ForEach(num => {Console.WriteLine(num % 2 == 0 ? num : null);});
            
            //Act 16
            string[] arrayStrings = { "Hola", "Que", "Tal", "?", "jeje" };
            List<string> listStrings = arrayStrings.ToList();
            listStrings.ForEach(str => {Console.WriteLine(str);});
            
            //Act 17
            Dictionary<string, int> dictionaryEmployees = new Dictionary<string, int>() { {"Eudald",12234},{"Hola",45667 } };
            foreach(var employee in dictionaryEmployees)
            {
                Console.WriteLine($"Nom: {employee.Key}, Salari: {employee.Value}");
            }
            
            //Act 18
            List<int> numList = new List<int>() { 1, 2, 3, 5, 7, 8, 4, 23, 23, 467, 5 };
            //No se puede hacer un foreach porque si borras el numero el foreach da error de exception (creo)
            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] > 30)
                {
                    numList.RemoveAt(i);
                }
            }
            
            //Act 19
            Operacio multiplicar = Multiplicar;
            Operacio dividir = Dividir;
            Console.WriteLine(multiplicar(234,2));
            Console.WriteLine(dividir(6,2));
            
            //Act 20
            Operacio sumar = (x, y) => x + y;
            Operacio restar = (x, y) => x - y;
            Operacio multiplicar = (x, y) => x * y;
            Operacio dividir = (x, y) => x / y;

            int resultat1 = ExecutarOperacion(10, 5, sumar);
            int resultat2 = ExecutarOperacion(10, 5, restar);
            int resultat3 = ExecutarOperacion(10, 5, multiplicar);
            int resultat4 = ExecutarOperacion(10, 5, dividir);

            Console.WriteLine($"Suma: {resultat1}");
            Console.WriteLine($"Resta: {resultat2}");
            Console.WriteLine($"Multiplicación: {resultat3}");
            Console.WriteLine($"División: {resultat4}");
            
            //Act 21
            Notificacio MostrarMissatgeConsola = missatge => Console.WriteLine(missatge); 
            Notificacio MostrarMissatgeAmbEstrelles = missatge => Console.WriteLine($"**{missatge}**");
            Notificacio MultiCast = MostrarMissatgeConsola + MostrarMissatgeAmbEstrelles;
            MultiCast("Hola");
            
            //Act 22
            Func<int, int, int> Funcio = (a,b) => a * b;
            //No retorna res perque els actions no retornen mai (void)
            Action<int, int> Action = (a, b) => Console.WriteLine(a + b);
            Console.WriteLine(Funcio(2, 4));
            Action(1, 56);
            
            //Act 23
            OperacioV metodeAnonim = delegate (int a, int b) 
            {
                Console.WriteLine(Math.Pow(a, b)); 
            };
            metodeAnonim(2, 3);
            */
            //Act 24
            ExecutarAmbMètodeAnonim(delegate {
                Console.WriteLine("Executar metode anonim test1");
            });
            ExecutarAmbMètodeAnonim(delegate {
                Console.WriteLine("Executar metode anonim test2");
            });
            ExecutarAmbMètodeAnonim(delegate {
                Console.WriteLine("Executar metode anonim test3");
            });

        }
        //Act 24
        public static void ExecutarAmbMètodeAnonim(DelegatAct24 delegat) => delegat();
        public delegate void DelegatAct24(); 
        //Act 23
        public delegate void OperacioV (int a, int b);
        //Act 21
        public delegate void Notificacio(string missatge);

        //Act 20
        public static int ExecutarOperacion(int num, int secondNum, Operacio operacio)
        {
            return operacio(num, secondNum);
        }
        //Act19
        public delegate int Operacio(int num, int secondNum);
        public static int Multiplicar(int num, int secondNum) => num * secondNum;
        public static int Dividir(int num, int secondNum) => num / secondNum;
        //Act 10
        public static int CompareDates(DateTime primeraData, DateTime segonaData)
        {
            return segonaData.CompareTo(primeraData);
        }
        //Act 11
        public static DayOfWeek DateToday() => DateTime.Today.DayOfWeek;
    }
}