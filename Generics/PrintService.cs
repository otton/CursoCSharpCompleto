using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class PrintService<T>
    {
        private T[] _values = new T[10]; //Variavel interna que poderá armazenar 10 numeros inteiros.
        private int _count = 0;
        public void AddValue(T value)
        {   //Programação defensiva
            if (_count == 10) //Se caso o contador já armazenou 10, o mesmo já está cheio
            {   //Print service ja está cheio.
                throw new InvalidOperationException("PrintService is full!");
            }
            _values[_count] = value; //Armazena o primeiro valor na variavel interna do vetor na posição do count que é 0.
            _count++; //Atualizar o contador.
        }

        public T First()
        {
            if (_count == 0) //Se caso o contador não armazenou nada, o Print service não tem o que mostrar.
            {   //PrintService está vazio.
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
