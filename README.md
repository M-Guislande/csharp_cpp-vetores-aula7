Vetores e Matrizes em C# e C++

Este repositório contém uma coleção de exemplos e exercícios resolvidos que exploram o uso de vetores (arrays dinâmicos) em C++ e matrizes (arrays bidimensionais) em C#. Os projetos demonstram operações fundamentais como leitura de dados, manipulação, busca e cálculos específicos nessas estruturas de dados.
Estrutura do Repositório

O repositório está organizado com os seguintes arquivos de exemplo:

    tarefa1.cpp: Implementa um algoritmo em C++ que lê 10 números inteiros, armazena-os em um vetor e, em seguida, classifica-os em dois novos vetores: um contendo apenas os números pares e outro com os números ímpares.
    tarefa2.cpp: Contém um programa em C++ que lê 10 números inteiros, solicita ao usuário um número para pesquisa e informa em quais posições ele aparece no vetor, além de quantas ocorrências foram detectadas.
    Program.cs (Distância entre Cidades): Um programa em C# que utiliza uma matriz predefinida para armazenar a distância entre quatro cidades (Vitória, Belo Horizonte, Rio de Janeiro e São Paulo). O usuário pode informar a cidade de origem e destino, e o programa retorna a distância correspondente, repetindo a consulta até que a origem e o destino sejam a mesma cidade.
    Program.cs (Multiplicação de Matrizes): Um algoritmo em C# que permite ao usuário inserir os valores para duas matrizes 3x3 (A e B), e então calcula e exibe o resultado da multiplicação matricial A * B.

Tecnologias Utilizadas

    C++: Utilizado para os exercícios com vetores.
        Compilador: G++ (ou similar)
        Bibliotecas padrão: <iostream>, <vector>
    C#: Utilizado para os exercícios com matrizes.
        Framework: .NET (ou .NET Core)
        Namespace: System

Como Compilar e Executar
C++ (tarefa1.cpp e tarefa2.cpp)

Para compilar e executar os arquivos C++, você precisará de um compilador C++ (como o G++).

    Navegue até a pasta do projeto:
    Bash

cd <caminho_para_o_seu_repositorio>

Compile o arquivo desejado:

    Para tarefa1.cpp:
    Bash

g++ tarefa1.cpp -o tarefa1

Para tarefa2.cpp:
Bash

    g++ tarefa2.cpp -o tarefa2

Execute o programa:

    Para tarefa1:
    Bash

./tarefa1

Para tarefa2:
Bash

        ./tarefa2

C# (Program.cs - Ambos os exemplos)

Para compilar e executar os arquivos C#, você precisará ter o .NET SDK instalado.

Como você possui dois arquivos Program.cs, eles devem estar em pastas separadas ou ter nomes diferentes para serem compilados e executados independentemente. Supondo que eles estejam em pastas distintas (ex: DistanciaCidades/Program.cs e MultiplicacaoMatrizes/Program.cs), você faria o seguinte:

    Navegue até a pasta do projeto C# específico (ex: DistanciaCidades):
    Bash

cd <caminho_para_o_seu_repositorio>/DistanciaCidades

Execute o programa:
Bash

    dotnet run

Repita para o outro projeto C# (MultiplicacaoMatrizes).

Observação: Se ambos os Program.cs estiverem na mesma pasta raiz, você precisará renomear um deles (ex: DistanciaCidades.cs, MultiplicacaoMatrizes.cs) e compilá-los explicitamente pelo nome do arquivo.
Destaques e Conceitos Abordados

    Vetores Dinâmicos em C++ (std::vector): Demonstra o uso de push_back() para adicionar elementos e empty() para verificar se o vetor está vazio.
    Arrays Bidimensionais (Matrizes) em C# (int[,]): Explora a declaração e manipulação de arrays multidimensionais para representação de tabelas de dados e matrizes matemáticas.
    Multiplicação de Matrizes: Implementação do algoritmo para multiplicar duas matrizes 3x3.
    Leitura de Entrada do Usuário: Interação com o usuário para entrada de dados em todos os programas.
    Tratamento de String em C#: Uso de ToLower() e Trim() para normalizar entradas de texto.
    Estruturas de Controle: Uso extensivo de for e while loops, bem como condicionais if/else e switch para controle de fluxo e lógica de programação.

Contribuição

Sinta-se à vontade para explorar os códigos, propor melhorias ou adicionar novos exemplos de manipulação de vetores e matrizes.

    Faça um fork do projeto.
    Crie uma branch para sua funcionalidade (git checkout -b minha-nova-funcionalidade).
    Faça suas alterações e commit (git commit -m 'Adiciona nova funcionalidade').
    Envie para a branch original (git push origin minha-nova-funcionalidade).
    Abra um Pull Request.
    
    ## Autor

* M-Guislande
