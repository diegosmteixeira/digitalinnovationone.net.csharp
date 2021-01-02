using System;

    // Como as classes, as structs são estruturas de dados que podem
    // conter membros de dados e membros de ação, mas, diferentemente das classes,
    // as structs são tipos de valor e não requerem alocação de heap
    //      heap = local da memória em que está o objeto referenciado
    //      stack = parte da memória em que a variável fica armazenada

    // Uma variável de um tipo de struct armazena diretamente os dados da estrutura,
    // enquanto uma variável de um tipo de classe armazena uma referência a um objeto
    // alocado na memória

    // Structs não aceitam herança determinada pelo desenvolvedor
    // São úteis para pequenas estruturas de dados que possuem semântica de valor:
    // números complexos; pontos em um sistema de coordenadas; pares de chave-valor em um
    // dicionário, etc.
    
    // O uso de structs em vez de classes para pequenas estruturas de dados pode fazer
    // uma grande diferença no número de alocações de memória

public struct Ponto
{
    public int x, y;
    public Ponto(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

// Construtores de structs são chamados com o operador new, semelhante a um construtor de classe,
// mas em vez de alocar dinamicamente um objeto no heap gerenciado e retomar uma referência a ele,
// um construtor struct simplesmente retorna o próprio valor struct (normalmente em um local temporário na stack),
// e esse valor é copiado conforme necessário.