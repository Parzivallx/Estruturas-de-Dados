Código C# DE Lista Ordenada:


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
            return;
        }

        NoOrdenado atual = cabeca;
        while (atual.Proximo != null && atual.Proximo.Dado < dado) {
            atual = atual.Proximo;
        }

        novoNo.Proximo = atual.Proximo;
        atual.Proximo = novoNo;
    }
}
Explicação do Código:

Classe NoOrdenado:

Representa um nó da lista.
Dado: Armazena o valor do nó (no caso, um inteiro).
Proximo: Ponteiro para o próximo nó na lista.
Classe ListaOrdenada:

cabeca: Ponteiro para o primeiro nó da lista.
InserirOrdenado(int dado): Método para inserir um novo elemento dado na lista, mantendo a ordem crescente.
Lógica de InserirOrdenado:

Criação do Novo Nó: Um novo nó novoNo é criado com o valor dado.
Lista Vazia ou Inserção no Início: Se a lista estiver vazia (cabeca == null) ou se o novo valor dado for menor que o valor do primeiro nó (dado < cabeca.Dado), o novo nó é inserido no início da lista.
Busca da Posição Correta: Se o novo nó não for inserido no início, a lista é percorrida a partir do segundo nó (atual = cabeca). O loop while continua até encontrar a posição onde o novo nó deve ser inserido.
Inserção no Meio ou Final: O novo nó é inserido na posição correta, atualizando os ponteiros dos nós adjacentes.
Conceito em Ação:

Imagine que você tem uma lista ordenada: 1 -> 3 -> 5. Se você quiser inserir o valor 4, o método InserirOrdenado irá:

Criar um novo nó com o valor 4.
Percorrer a lista até encontrar a posição correta (entre 3 e 5).
Inserir o novo nó nessa posição, resultando na lista: 1 -> 3 -> 4 -> 5.
Benefícios da Lista Ordenada:

Busca Eficiente: A ordem dos elementos permite buscas mais rápidas, como a busca binária.
Manutenção da Ordem: Os elementos estão sempre em ordem, facilitando a recuperação de dados ordenados.
