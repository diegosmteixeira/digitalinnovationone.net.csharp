using System;

namespace DigitalInnovationOne
{
    class Array
    {
        // Um array é uma estrutura de dados que contém um
        // número X de elementos, todos do mesmo tipo, que são
        // acessados através de índices computados

        // Arrays são tipos de referência e a declaração de uma variável
        // array simplesmente reserva espaço para uma referência de 
        // uma instância de array

        // O espaço da variável apenas aponta para o array criado

        // Ao criar um array é especificado o tamanho da nova instância,
        // que é o fixo durante todo o tempo de vida da instância

        // Os índices dos elementos de um array
        // variam de 0 a comprimento do array -1

        int [] a = new int[10];
        
        for (int i = 0; 1 < a.Lenght; i++)
        {
            a[i] = i * i;
        }

        for (int i = 0; i < a.Lenght; i++)
        {
            Console.WriteLine($"a[{i}] = {a[i]}");
        }
        
        //Array multidimensional - matrizes

        int[,] a2 = new int[10, 5];
        int[,,] a3 = new int[10, 5, 2];

        
        //Inicializador de array

        //primeira forma
        int[] a = new int[]{1, 2, 3};
        
        //segunda forma
        int[] a = {1, 2, 3};           

        //terceira froma
        int[] t = new int[3];
        t[0] = 1;
        t[1] = 2;
        t[2] = 3;

        //quarta forma
        int[] a = t;

    }
}