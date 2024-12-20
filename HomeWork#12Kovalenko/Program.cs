using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork_12Kovalenko
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("ВВедвіть порядковий номер Фібоначі - ");
            string inputNuber = Console.ReadLine();
            if (int.TryParse(inputNuber, out int serialNumber))
            { 
                NumberFibonachi(0, 0, 1, 0, serialNumber);
               
            }

            else { Console.WriteLine("Некоректний формат вводу!"); }
            
        }
        //    f1  f2  s | f1  f2  s | f1   f2   s            
        // 0  1   1   2   3   5   8   13   21   34
        //f1  f2  s | f1  f2  s | f1  f2   s |              
        static void NumberFibonachi(int serialNumber, int valueFibonache1, int valueFibonache2, int sumValue, int step)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            step--;
            serialNumber++;

            valueFibonache1 = valueFibonache2;
                valueFibonache2 = sumValue;
              
                 
            sumValue = valueFibonache1 + valueFibonache2;

            if (step - 1 == 0)
            {
                Console.WriteLine($"Порядковому номеру {serialNumber + 1} відповідає число Фібоначі {sumValue}");
                return; 
            }

            NumberFibonachi( serialNumber, valueFibonache1, valueFibonache2, sumValue, step);
           
        }
    }
}
