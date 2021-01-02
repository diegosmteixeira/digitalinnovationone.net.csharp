using System;

public class Classes
{
    // Classes são os tipos mais fundamentais de C#

    // Uma classe é uma estrutura de dados que combina estado (campos)
    // e ações(métodos).

    // As classes suportam herança e polimorfismo,
    // mecanismos pelos quais as Classes derivadas 
    // podem estender e especializar as Classes base

}

public class Objetos 
{

    //Objetos são instâncias de uma classe

}

public class Ponto
{
    public int x, y;
    public Ponto(int x, int y)
    {
        //coloca os valores passados nos parâmetros internos da classe
        this.x = x; 
        this.y = y;
    }
    Ponto p2 = new Ponto(10, 20);
}

// Instâncias de classes (objetos) são criadas usando o operador new(),
// que aloca memória para uma nova instância, chama um construtor para
// inicializar a instância e retoma uma referência à instância

//A memória ocupada por um objeto é recuperada automaticamente
// quando o objeto não está mais acessível. Não é necessário
// nem possível desalocar explicitamente objetos em C#

public class Membros
{
    //Os membros de uma classe podem ser estáticos ou membros da instância.

    // Membros estáticos pertencem a classe e 
    // membros de instância pertencem ao objeto.

    // Constantes, variáveis, métodos, propriedades, construtores
    // etc
}

public class Acessibilidade
{
    // Cada membro de uma classe tem uma acessibilidade associada, 
    // que controla as regiões do programa que podem 
    // acessar o membro

    // Podem ser:
    // public
    // protected (protegido - apenas as classes que herdam da classe base tem acesso ao método)
    // internal  (só pode ser acessado de dentro do assembly que faz parte)
    // private   (acessado única e exclusivamente dentro da classe que está contido)
}

public class Heranca
{
    // Uma declaração de classe pode especificar uma classe base,
    // herdando os membros public, internal e protected
    // da classe base
    
    // Omitir uma especificação de classe base é o mesmo
    // que derivar do tipo object (tipo base de referência do C#)
}

public class Metodos
{
    // Um método é um membro que implementa uma computação ou ação que pode ser
    // executada por um objeto ou classe

    // Os métodos podem ter uma lista de parâmetros, que representam valores
    // ou referências de variáveis passados para o método, e um tipo de retorno,
    // que especifica o tipo do valor calculado e retornado pelo método.

    // Uma boa prática é que métodos tenham nomes de ações
    // atributos sejam substantivos
}

