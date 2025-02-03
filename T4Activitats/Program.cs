using System;
using T4Activitats;
namespace Activitats
{
    public class Act
    {
        public static void Main()
        {
            Parella<string, int> parellaTest1 = new Parella<string, int>("Hola", 2);
            parellaTest1.MostrarValors();
            Parella<double, bool> parellaTest2 = new Parella<double, bool>(3.4, true);
            parellaTest2.MostrarValors();
        }
    }
}