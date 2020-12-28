using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Como funciona o C#
                /* O código fonte é compilado em uma linguagem intermediária (IL)
                Tanto o código e os recursos de IL são armazenados no disco em 
                um arquivo executável assembly, geralmente com uma extensão .exe ou .dll
                */

                /* Quando o programa C# é executado, o assembly é carregado no CLR
                Então, o CLR executa a compilação just in time (JIT) para converter
                o código IL em instruções de máquina nativas*/

                /* O CLR também fornece serviços como:
                - Garbage Collector (desaloca da memória o que não está em uso)
                - Exception Handler (recebe e trata as exceções)
                - Resources Manager (gerenciador de recursos)
                */

            //Estrutura de programa C#
                /*Os principais conceitos organizacionais C#
                - programas
                - namespaces
                - tipos
                - membros
                - assemblies
                */
                    /*Programas (formados por um ou mais arquivos)
                    declaram tipos, que contêm membros, e podem ser 
                    organizados em namespaces*/

                    //Classes e interfaces são exemplos de tipos

                    //Campos, métodos, propriedades e eventos são exemplos de membros
                    
            Console.WriteLine("Estrutura de Programa C#!");
        }
    }
}
