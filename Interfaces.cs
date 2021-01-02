using System;

    // Uma interface define um contrato que pode ser implementado 
    // por classes e structs

    // *apesar de structs não permitirem herança, elas podem 
    // implementar interfaces

    // Uma interface pode conter métodos, propriedades, eventos e indexadores

    // Uma interface não fornece implementações dos membros que define
    // - apenas suas "assinaturas"
    // ou seja, a interface possui uma assinatura do método e é um contrato
    
    // quem implementar uma interface, obrigatoriamente deve possuir
    //  o método implementado

    // As interfaces podem empregar herança múltipla

interface IControl
{
    // quem implementar a interface obrigatoriamente deve ter esse método
    void Paint();
}
interface IListBox
{
    void SetText(string text);
}
// quem implementar a IComboBox tem que implementar obrigatoriamente
// as outras duas das quais ela está herdando
interface IComboBox: IControl, IListBox {}

// Em síntese: as Interfaces determinam coisas que determinadas classes devem
// implementar. É como se fosse um contrato entre as classes que utilizam a interface.