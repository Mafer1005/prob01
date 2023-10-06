using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año,cantidadpeso,peso, cantidad, i;
            float tarifa;
            i = 0;
            Console.WriteLine("Ingrese la cantidad de autos: ");
            cantidad=int.Parse(Console.ReadLine());
            for (i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Auto "+ i);
                Console.WriteLine("Ingrese el año del automovil: ");
                año = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el peso del automovil: ");
                peso = int.Parse(Console.ReadLine());
                if (año <= 1970)
                {
                    if (peso < 2700)
                    {
                        tarifa = 16.50f;
                        cantidadpeso = 1;
                        Console.WriteLine("La clase del automovil es " + cantidadpeso);
                        Console.WriteLine("La tarifa del auto registrado es " + tarifa);
                    }
                    else if (peso >= 2700 && peso <= 3800)
                    {
                        tarifa = 25.50f;
                        cantidadpeso = 2;
                        Console.WriteLine("La clase del automovil es " + cantidadpeso);
                        Console.WriteLine("La tarifa del auto registrado es " + tarifa);
                    }
                    else 
                    {
                        tarifa = 46.50f;
                        cantidadpeso = 3;
                        Console.WriteLine("La clase del automovil es " + cantidadpeso);
                        Console.WriteLine("La tarifa del auto registrado es " + tarifa);
                    }
                }
                if (año >= 1971 && año <= 1979)
                {
                    if (peso < 2700)
                    {
                        tarifa = 27.00f;
                        cantidadpeso = 4;
                        Console.WriteLine("La clase del automovil es " + cantidadpeso);
                        Console.WriteLine("La tarifa del auto registrado es " + tarifa);
                    }
                    else if (peso >= 2700 && peso <= 3800)
                    {
                        tarifa = 30.50f;
                        cantidadpeso = 5;
                        Console.WriteLine("La clase del automovil es " + cantidadpeso);
                        Console.WriteLine("La tarifa del auto registrado es " + tarifa);
                    }
                    else
                    {
                        tarifa = 52.50f;
                        cantidadpeso = 6;
                        Console.WriteLine("La clase del automovil es " + cantidadpeso);
                        Console.WriteLine("La tarifa del auto registrado es " + tarifa);
                    }
                }
                if (año >= 1980)
                {
                    if (peso < 3500)
                    {
                        tarifa = 19.50f;
                        cantidadpeso = 7;
                        Console.WriteLine("La clase del automovil es " + cantidadpeso);
                        Console.WriteLine("La tarifa del auto registrado es " + tarifa);
                    }
                    else if (peso >= 3500)
                    {
                        tarifa = 52.50f;
                        cantidadpeso = 8;
                        Console.WriteLine("La clase del automovil es " + cantidadpeso);
                        Console.WriteLine("La tarifa del auto registrado es " + tarifa);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
