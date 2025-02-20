using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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
            List<int> numList = new List<int>() {1,2,3,5,7,8,4,23,23,467,5 };
            Console.WriteLine(numList.Sum());
            
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
            
            //Act 25
            Func<int, int, int> Funcio = (a,b) => a + b;
            var variableFuncio = Funcio(2,5);
            Console.WriteLine(variableFuncio)
            
            //Act 26
            Console.WriteLine("Introdueix un email:");
            string email = Console.ReadLine();
            Console.WriteLine(IsValidEmail(email)? "L'email es valid" : "L'email no es valid");
            
            //Act 27
            Console.WriteLine("Introdueix un telefon: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine(IsValidPhoneNumber(phoneNumber) ? "El numero es valid" : "El numero no es valid");
            
            //Act 28
            Console.WriteLine(ExtractNumRegex("Avui és el dia 12 del mes 02 de l'any 2024"));
            
            //Act 29
            Console.WriteLine(ValidatePassword("HolaComo345@"));
            
            //Act 30
            Console.WriteLine(ValidatePostalCode("01000"));
            */
            //Act 31
            //a 
            int[] valors = { 1, 2, 23, 4, 4, -6, 7, 8, -86,-10 };
            var queryA = from valor in valors
                             where valor % 2 == 0
                             select valor;
            Console.WriteLine("QueryA");
            foreach(var i in queryA)
            {
                Console.WriteLine(i + " ");
            }
            //b
            var queryB = from valor in valors
                             where valor > 0
                             select valor;
            Console.WriteLine("QueryB");
            foreach (var i in queryB)
            {
                Console.WriteLine(i + " ");
            }
            //c
            var queryC = from valor in valors
                              where valor > 20
                              select valor * valor;
            Console.WriteLine("QueryC");
            foreach (var i in queryC)
            {
                Console.WriteLine(i + " ");
            }
            //d
            int iForD = 0;
            var queryD = from valor in valors
                         select valors.Count(n => n == valor);  
            Console.WriteLine("QueryD");
            foreach (var i in queryD)
            {
                Console.WriteLine($"Numero: {valors[iForD]}, Freqüencia:\t{i} ");
                iForD++;
            }
            //e
            string textE = "Hola Prova";
            int iForE = 0;
            var queryE = from valor in textE
                         select textE.Count(n => n == valor);
            Console.WriteLine("QueryE");
            foreach(var i in queryE)
            {
                Console.WriteLine($"{textE[iForE]}:\t{i} ");
                iForE++;
            }
            //f
            List<string> listWeekDays = new List<string> { "Dilluns", "Dimarts", "Dimecres", "Dijous", "Divendres", "Dissabte", "Diumenge" };
            //g
            int iForG = 0;
            var queryG = from valor in valors
                         select valor * valors.Count(n => n == valor);
            Console.WriteLine("QueryG");
            foreach (var i in queryG)
            {
                Console.WriteLine($"Numero: {valors[iForG]}, Multiplicat per la freqüencia:\t{i} ");
                iForG++;
            }
        }
        //Act 30
        public static bool ValidatePostalCode(string str) => Regex.IsMatch(str, "^(0[1-9]\\d{3}|[1-4]\\d{4}|5[0-2]\\d{3})$");
        /*
         ^ indica l'inici de la cadena.

        0[1-9]\d{3} valida codis postals entre 01000 i 09999.

        [1-4]\d{4} valida codis postals entre 10000 i 49999.

        5[0-2]\d{3} valida codis postals entre 50000 i 52999.

        $ indica el final de la cadena.
        */
        //Act 29
        public static bool ValidatePassword(string str) => Regex.IsMatch(str, "^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$");
        /*
         ^ indica l'inici de la cadena.

        (?=.*[A-Z]) assegura que hi hagi almenys una lletra majúscula.

        (?=.*[a-z]) assegura que hi hagi almenys una lletra minúscula.

        (?=.*\d) assegura que hi hagi almenys un número.

        (?=.*[@$!%*?&]) assegura que hi hagi almenys un símbol especial (podeu afegir o modificar els símbols especials segons les vostres necessitats).

        [A-Za-z\d@$!%*?&]{8,} assegura que la longitud total sigui de mínim 8 caràcters i permet només les lletres, números i símbols especials especificats.

        $ indica el final de la cadena.
         */
        //Act 28
        public static string ExtractNumRegex(string str)
        {
            StringBuilder sr = new StringBuilder();
            int outIndex = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (Regex.IsMatch(str[i].ToString(), @"[0-9]"))
                {
                    int currentI = i;
                    do
                    {
                        sr.Append(str[currentI]);
                        currentI++;
                        outIndex = currentI > str.Length - 1 ? currentI - 1 : currentI;
                    } while (Regex.IsMatch(str[outIndex].ToString(), @"[0-9]") && str.Length > currentI);
                    sr.Append(", ");
                    i = currentI;
                }
            }
            return sr.ToString();
        }
        //Act 27
        public static bool IsValidPhoneNumber(string phone)
        {
            if (Regex.IsMatch(phone, @"^[6-9][0-9]{2} [0-9]{3} [0-9]{3}$"))
            {
                return true;
            }
            else if (Regex.IsMatch(phone, @"[+34] [6-9][0-9]{3} [0-9]{3} [0-9]{3}$"))
            {
                return true;
            }
            else if (Regex.IsMatch(phone, @"^[6-9][0-9]{9}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Act 26
        public static bool IsValidEmail(string email) => Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]");
        //Act 24
        public static void ExecutarAmbMètodeAnonim(DelegatAct24 delegat) => delegat();
        public delegate void DelegatAct24(); 
        //Act 23
        public delegate void OperacioV (int a, int b);
        //Act 21
        public delegate void Notificacio(string missatge);

        //Act 20
        public static int ExecutarOperacion(int num, int secondNum, Operacio operacio) => operacio(num, secondNum);
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