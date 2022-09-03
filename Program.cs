using System;

namespace Collatz
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = 1,max = decimal.MaxValue;
            Console.WriteLine("\nConjectura de Collatz:\n\nn deve ser maior que Zero;\nSe n for par:(n / 2);\nSe n for ímpar:(3n + 1);\nO resultado final sempre será 1.\n");

            while(number != 0) {

                int ct = 0, cnt = 0;
                decimal lg = 0;

                do{Console.Write("Para encerrar o programa digite 0.\n\nDigite um número: ");
                    number = Convert.ToDecimal(Console.ReadLine());}
                while(number < 0);

                while(cnt != 1)
                {
                    if(number == 0)
                    {
                        break;
                    }

                    if(number % 2 == 0)
                    {
                        number /= 2;
                        // Console.Write("{0} / 2 = ",number);
                    }

                    else
                    {   
                        if(number >= max / 3)
                        {
                            Console.WriteLine("\n\n\n\t\t\tAtenção!\n\n\nO número ultrapassou o limite máximo de uma variável do tipo decimal\n\nLimite Máximo: {0}",max);
                            break;
                        }

                        number *= 3;
                        number++;
                        // Console.Write("{0} * 3 + 1 = ",number);
                    }

                    if(number == 1)
                    {
                        cnt++;
                    }
                    ct++;

                    if(number == 1)
                    {
                        Console.WriteLine("{0}º -> {1} !", ct, number);
                    }

                    else
                    {
                        Console.WriteLine("{0}º -> {1}", ct, number);
                    }

                    if(number > lg)
                    {
                        lg = number;
                    }

                }

                if(number != 0)
                {
                    Console.WriteLine("\nMaior Número = {0}\n---------------------------------------", lg);
                }
            }
        }
    }
}
