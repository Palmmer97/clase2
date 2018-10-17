using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueClass
{
   public class Cola
    {
       private ArrayList pcola;
       // Crear la lista 
       public Cola()
       {
           pcola = new ArrayList();

       }
       // Agrega el objeto de entrada al arraylist
       // el objeto puede ser cualquier tipo de dato.
       public void EnQueue(object item)
       {
           pcola.Add(item);
       }
       //Elimina la posicion 0 de la lista permitiendo sacar ese elemento
 
       public void DeQueue()
       {
           pcola.RemoveAt(0);
       }
       //peek deja ver el ultimo elemento 
       public object Peek()
       {
           return pcola[0];
       }
       public void ClearQueue()
       {
           //vacia los elementos de la cola 
           pcola.Clear();

       }
       //Regresa la cantidad de elementos de 1 a cola 
       public int Count()
       {
           return pcola.Count;
       }
   


    }

}
