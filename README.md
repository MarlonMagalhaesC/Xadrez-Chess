Projeto Jogo de Xadrez (Chess Game Project)

![xadrez](https://github.com/user-attachments/assets/bd1342c2-73c4-4058-b128-68cc472ab281)


Descrição do Projeto
Este projeto é uma implementação de um jogo de xadrez em C#. O jogo é jogado em um tabuleiro de 8x8 e permite que dois jogadores façam suas jogadas alternadamente. O projeto utiliza a programação orientada a objetos (POO) para representar as peças, o tabuleiro e a lógica do jogo. As principais funcionalidades incluem movimentação de peças, captura, verificação de xeque e xeque-mate, e a jogada especial "en passant".

Funcionalidades
Tabuleiro: Representa o tabuleiro de xadrez com suas 64 casas.
Peças: Implementa as regras de movimentação para cada tipo de peça (Rei, Dama, Torre, Cavalo, Bispo e Peão).
Partida de Xadrez: Controla a lógica do jogo, como turnos, verificação de xeque e xeque-mate, e gerenciamento de peças capturadas.
Interface de Usuário: Utiliza o console para interagir com os jogadores, exibindo o tabuleiro e permitindo que eles façam suas jogadas.
O que aprendemos com o projeto
Programação Orientada a Objetos (POO):

Classes e Objetos: Utilizamos classes para representar entidades do jogo, como Peca, Tabuleiro, PartidaDeXadrez e classes específicas para cada tipo de peça (como Rei, Dama, Torre, etc.).
Herança: As classes de peças herdam de uma classe base Peca, permitindo a reutilização de código e a definição de comportamentos comuns (como o método movimentosPossiveis).
Encapsulamento: As propriedades e métodos das classes são encapsulados, garantindo que os dados sejam acessados e modificados de maneira controlada.
Polimorfismo: O uso de métodos sobrescritos em subclasses (como o método ToString para representar as peças) demonstra o conceito de polimorfismo.
Estruturas de Dados:

Listas e HashSets: Utilizamos List<Peca> para armazenar as peças ativas na partida e HashSet<Peca> para gerenciar as peças capturadas, permitindo uma busca eficiente e a eliminação de duplicatas.
Matrizes: O tabuleiro é representado como uma matriz bidimensional (bool[,]) para gerenciar os movimentos possíveis de cada peça, facilitando a visualização e o controle das posições.
Enums:

Cor: Utilizamos um enum Cor para representar as cores das peças (Branca e Preta), tornando o código mais legível e reduzindo a possibilidade de erros relacionados a valores de cores.
Posição: A classe PosicaoXadrez e Posicao ajudam a gerenciar as posições no tabuleiro de forma estruturada.

Tratamento de Exceções:
Implementamos exceções personalizadas (como TabuleiroException) para tratar erros relacionados a movimentos inválidos, entradas de usuários e outros problemas, aumentando a robustez do programa.

Interação com o Usuário:

Utilizamos a entrada e saída de dados pelo console, permitindo que os jogadores interajam com o jogo de forma intuitiva.
Tecnologias e Ferramentas Usadas
C#: Linguagem de programação utilizada para implementar a lógica do jogo.
.NET: Plataforma para desenvolvimento e execução do aplicativo.
Visual Studio: IDE utilizada para desenvolvimento e depuração do código.

Conclusão
Este projeto foi uma excelente oportunidade para aprimorar habilidades em programação orientada a objetos, lógica de programação e manipulação de interfaces de usuário. O jogo de xadrez, com sua complexidade e regras, serviu como um ótimo exemplo de como a programação pode ser utilizada para criar experiências interativas e desafiadoras.
