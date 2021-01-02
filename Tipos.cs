using System;

namespace DigitalInnovationOne
{
    class Tipos
    {
    static void Main(string[] args) 
    {
        //Tipos de valor

                /*essas variáveis de Tipo de Valor contêm diretamente seus dados
                - As variáveis tem suas próprias cópias de dados e não é possível
                que as operações afetem outra variável.

                Cada variável tem a cópia dos dados efetivas,
                assim qualquer operação que seja feita entre duas variáveis
                gera uma terceira variável, de modo que as outras permaneçam intactas.

                (exceto no caso das variáveis de parâmetro ref e out)
                Com esses parâmetros é possível forçar a mudança na memória do espaço
                que a variável referencia e trocar o valor.
                */
            
            //Exemplos de Tipo de valor:
            
            //Numéricos:
            // sbyte, short, int, long, byte, unshort, uint, ulong

            //Caracteres Unicode:
            // char

            //Pontos flutuantes: 
            // float, double, decimal

            //Booleano:
            // Booleano

            //enum, struct e tipos nullabe (Exemplo int?)
            /*o inteiro por padrão começa com o valor zero
            ao ao utilizar o interrogação ele se torna um tipo nullable
            que passa a poder receber o valor null
            */
    
    //Tipos de referência

            /*variáveis de tipos de referência armazenam referências a seus dados
            ou seja, elas não possuem os dados diretamente vinculados a elas na memória
            mas somente guardam uma referência ao local no qual esses dados estão armazenados.
            
            É possível que duas variáveis façam referência ao mesmo objeto e,
            portanto, que operações em uma variável afetem o objeto referenciado
            pela outra variável.

            Assim, ao alterar uma variável a outra também sofrerá alteração, visto que
            ambas apontam para a mesma referência, o mesmo dado na memória.]
            */

        //Exemplos de tipo referência

        //Tipos de Classe:
        // class, object, string

        //Tipos Arrays:
        // int[], int[,] //etc

        // interface, delegate

    }

}
}
