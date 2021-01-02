using System;

enum Enums
{
    // Um enum é um tipo de valor distinto com um conjunto de constantes
    // nomeadas

    // Você define enumerações quando precisa definir um tipo que pode
    // ter um conjunto de valores discretos.

    // Eles usam um dos tipos de valor integral como armazenamento
    // subjacente. Eles fornecem significado semântico aos valores 
    // discretos

    Vermelho,
    Verde,
    Azul
}

// Cada tipo de enum possui um tipo integral correspondente
// chamado tipo subjacente do tipo de enum

// Um tipo de enumeração que não declara explicitamente um tipo
// subjacente tem um tipo subjacente int

enum Alinhamento: sbyte
{
    Esquerda = -1,
    Centro = 0,
    Direita = 1
}