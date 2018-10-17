using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola miCola = new Cola();


            for (int i = 0; i < 5; i++)
            {
                Console.Write("Indroduce los elementos{0} de la cola", i+1);
                var Elem = Console.ReadLine();
                miCola.EnQueue(Elem);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(miCola.Peek());
                miCola.DeQueue();
            }
            Console.ReadKey();
            // Inicializacion de las colas con datos 
            Queue queue = new Queue(100);
            // capacidad y el factor de crecimiento de la cola 
            Queue miQueue = new Queue(100, 3);
            //Cola con tipo de dato especifico 
            Queue<int> numeros = new Queue<int>();

            Queue mico = new Queue();

            
        }
    }
}
