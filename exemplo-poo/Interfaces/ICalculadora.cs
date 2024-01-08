using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo.Interfaces
{
    public interface ICalculadora
    {
        double Somar(double num1, double num2);
        double Subtrair(double num1, double num2);
        double Multiplicar(double num1, double num2);
        double Dividir(double num1, double num2) 
        {
            return num1 / num2;
        }
    }
}