using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pagoEventual
{
    class Program
    {
        class pago
        {
           /* private int horas;
            private float sueldo;
            public void inicio()
            {
                Console.WriteLine("introdusca los horas trabajados");
                horas = int.Parse(Console.ReadLine());
            }
            public void Descuento()
            {
                if (horas >= 5 && horas < 7)
                {
                    horas = horas*10;
                    int bono = (horas * 20) / 100;
                    sueldo = horas + bono;
                    Console.WriteLine("su bono es:" + bono);
                    Console.WriteLine("su total es:" + sueldo);
                    Console.ReadLine();
                }
                if (horas >= 7 && horas <= 10)
                {
                    horas = horas * 10;
                    int bo = (horas * 30) / 100;
                    sueldo = horas + bo;
                    Console.WriteLine("su bono es:" + bo);
                    Console.WriteLine("su total es:" + sueldo);
                    Console.ReadLine();
                }
                else
                {
                    sueldo = horas * 10;
                    Console.WriteLine("no tiene bono");
                    Console.WriteLine("su suelto total es:" + sueldo);
                    Console.ReadLine();
                }
            }*/
            public void fac()
            {
                Console.WriteLine("intro nnum");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    int r = 0;
                     r = n * i;
                    Console.WriteLine("resp" + r);
                }
                Console.ReadLine();
            }

        }
        static void Main(string[] args)
        {
            pago ob = new pago();
           // ob.inicio();
          //  ob.Descuento();
            ob.fac();
        }
    }
}
