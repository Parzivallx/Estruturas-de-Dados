1. Lista Encadeada Simples ():

public class NoSimples {
    public int Dado;
    public NoSimples Proximo;
}
public class ListaSimples {
    public NoSimples cabeca;
    
    public void Adicionar(int dado) {
        NoSimples novoNo = new NoSimples { Dado = dado, Proximo = cabeca };
        cabeca = novoNo;
    }
}
// Exemplo de uso:
ListaSimples lista = new ListaSimples();
lista.Adicionar(1);
lista.Adicionar(2);

Explicação: Este código cria uma lista simples onde novos elementos são adicionados no início. A propriedade Proximo de cada nó aponta para o próximo nó na lista.0

    
2. Lista Duplamente Encadeada ():
public class NoDuplo {
    public int Dado;
    public NoDuplo Proximo;
    public NoDuplo Anterior;
}

public class ListaDupla {
    public NoDuplo cabeca;
    public NoDuplo cauda;

    public void Adicionar(int dado) {
        NoDuplo novoNo = new NoDuplo { Dado = dado };
        if (cabeca == null) {
            cabeca = novoNo;
            cauda = novoNo;
        } else {
            cauda.Proximo = novoNo;
            novoNo.Anterior = cauda;
            cauda = novoNo;
        }
    }
}
// Exemplo de uso:
ListaDupla lista = new ListaDupla();
lista.Adicionar(1);
lista.Adicionar(2);

Explicação: Este código cria uma lista duplamente encadeada. Novos elementos são adicionados no final. As propriedades Proximo e Anterior de cada nó permitem a navegação bidirecional.

3. Lista Encadeada Ordenada ():
public class NoOrdenado {
    public int Dado;
    public NoOrdenado Proximo;
}
public class ListaOrdenada {
    public NoOrdenado cabeca;

    public void InserirOrdenado(int dado) {
        NoOrdenado novoNo = new NoOrdenado { Dado = dado };
        if (cabeca == null || dado < cabeca.Dado) {
            novoNo.Proximo = cabeca;
            cabeca = novoNo;
        } else {
            NoOrdenado atual = cabeca;
            while (atual.Proximo != null && atual.Proximo.Dado < dado) {
                atual = atual.Proximo;
            }
            novoNo.Proximo = atual.Proximo;
            atual.Proximo = novoNo;
        }
    }
}
// Exemplo de uso:
ListaOrdenada lista = new ListaOrdenada();
lista.InserirOrdenado(3);
lista.InserirOrdenado(1);
lista.InserirOrdenado(2);

Explicação: Este código cria uma lista ordenada onde novos elementos são inseridos na posição correta para manter a ordem crescente.

4. Lista Encadeada Circular ():
public class NoCircular {
    public int Dado;
    public NoCircular Proximo;
}

public class ListaCircular {
    public NoCircular cabeca;

    public void Adicionar(int dado) {
        NoCircular novoNo = new NoCircular { Dado = dado };
        if (cabeca == null) {
            cabeca = novoNo;
            novoNo.Proximo = cabeca;
        } else {
            NoCircular atual = cabeca;
            while (atual.Proximo != cabeca) {
                atual = atual.Proximo;
            }
            atual.Proximo = novoNo;
            novoNo.Proximo = cabeca;
        }
    }
}
// Exemplo de uso:
ListaCircular lista = new ListaCircular();
lista.Adicionar(1);
lista.Adicionar(2);
lista.Adicionar(3);

Explicação: Este código cria uma lista circular onde o último nó aponta para o primeiro nó. A lista pode ser percorrida em um ciclo contínuo.
