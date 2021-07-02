# AAP_SGDC

# Título do projeto

Sistema gerenciador de contatos

# Participantes

Lucas Medeiros Galindo

# Área ou linha de pesquisa

Sistema gerenciador de contatos

# Palavras-chave

Gerenciamento, contatos, serviço, nuvem, web.

# Duração do trabalho

Início: MARÇO/2021 - Término: JUNHO/2021

# Contextualização

A história da lista telefônica do Brasil certamente faz parte da história da telefonia do país. Em janeiro de 1881, a Companhia Telefônica do Brasil foi fundada na Rua da Quitanda, no Rio de Janeiro, sendo a primeira empresa de telefonia do país. Na mesma ocasião, a empresa publicou em uma das páginas do Jornal do Commercio, publicado em 21 de agosto de 1881, a primeira lista telefônica do Brasil.

Para pesquisar números de telefone, as pessoas usam anúncios em jornais. No início de cada mês, as informações do novo proprietário de telefone eram publicadas no jornal, disponibilizando o número do telefone e o endereço. Foi dessa forma que a Companhia de Telégrafos Urbanos (Ferdinand Rodde & Co.) publicou na edição do dia 8 de janeiro de 1884, no jornal A Província de S. Paulo, hoje O Estado de S. Paulo, a primeira lista telefônica da cidade de São Paulo, com 22 assinantes.

Com o avanço do número de assinantes, as listas deixaram de ser publicadas nos jornais e passaram a ser impressas pelas próprias empresas telefônicas. As listas telefônicas permaneceram a ser editadas pelas próprias concessionárias de serviços telefônicos até 1946, principalmente pela Companhia Telefônica Brasileira, a maior empresa do Brasil na época.

Softwares e aplicativos de listas telefônicas são disponibilizados para instalação e utilização nas mais variadas e diversas plataformas como computadores, tablets ou celulares, necessitando-se ou não de Internet para realizar uma procura.

As versões on-line das tradicionais listas impressas são produzidas por editoras especializadas em todo o mundo. As funcionalidades das listas on-line são semelhantes às tradicionais, incluem listagens alfabéticas de empresas que podem ser pesquisas por nome da empresa, tipo de atividade, produto ou serviço. Diferentemente das listas impressas limitadas por espaço físico, as versões on-line permitem através de um único meio (Internet) obter informações sobre centenas de milhares de empresas ao redor do mundo, bem como obter informações adicionais sobre o perfil das empresas e seus produtos e serviços. Uma das vantagens das versões on-line é que elas são atualizadas diariamente, permitindo maior precisão das listagens já que informações podem ser alteradas a qualquer momento.

Assim como a guardar telefones de empresas, as pessoas também têm a necessidade de armazenar seus contatos pessoais, números de amigos, parentes e afins. A forma mais comum utilizada era a de utilizar um pequeno caderno e realizar as anotações dos dados manualmente com uma caneta.

Com o surgimento dos telefones celulares e telefones com memória interna, a possibilidade de registro desses dados se tornou o primeiro passo para um armazenamento totalmente digital, entretanto, esses dados ficam limitados a estes aparelhos, e caso fossem danificados, esses dados seriam perdidos.

Em meio a esta dificuldade, a utilização de serviços online de armazenamento tem se tornado cada vez mais populares devido a sua confiabilidade e portabilidade, estando sempre disponível para o usuário.

# Formulação do problema

Quantas vezes alguém precisou ter acesso a sua agenda de contatos independentemente de onde estava ou trocou de telefone e perdeu todos os seus contatos?

# Objetivos

## Objetivo geral

Desenvolver um sistema online que organize e gerencie os contatos pessoais.

## Objetivo específico

O usuário só poder ver contatos que ele cadastrou.

# Justificativa do trabalho

Para gerenciar melhor os contatos, eles não devem ser armazenados em dispositivos físicos, mas sim em nuvem. Portanto, um software de gerenciamento de contatos será criado para armazená-los, torná-los disponíveis e compatível com qualquer dispositivo a qualquer momento.

O sistema terá a capacidade de adicionar, editar e excluir contatos, separá-los por grupos e torná-los acessíveis aos usuários do sistema. Através deste site, será possível gerenciar os contatos adicionados de uma forma simplificada.

# Metodologia e plano de trabalho

Para o desenvolvimento do software de gerenciamento de contatos foi utilizado a linguagem de programação C#, conectado corretamente a um banco de dados SQL, construído através do SGBD MySQL, utilizando a metodologia orientadas a objetos, com base no diagrama de caso de uso, diagrama de classes, diagrama de atividades e diagrama de sequência.

## Especificações dos requisitos

### Requisitos funcionais

- RF01- O site iniciará em uma tela de autenticação do usuário para acesso ao sistema;
- RF02- Após acessar o sistema o usuário poderá alterar seus dados e de seus contatos;
- RF03- A página inicial apresentará um menu com todas as opções necessárias para cada usuário;
- RF04- O sistema possuirá funções de inclusão, exclusão e alteração de contatos;
- RF05- O sistema deverá armazenar informações importantes dos contatos adicionados pelo usuário;
- RF06- O usuário só terá acesso aos contatos que ele próprio cadastrou;

### Requisitos não funcionais

- RNF01- O usuário deverá criar um cadastro para ingressar ao sistema;
- RNF02- O sistema será constituído da linguagem de programação C# (ASP.Net Web Forms);
- RNF03- O banco de dados desempenhará da linguagem SQL e terá como SGBD o MySql;
- RNF04- O padrão de arquitetura de software irá consistir no MVC e o paradigma de programação em OO;

## Modelagem do sistema

Para este projeto será utilizado quatro modelos UML, diagrama de classes, diagrama de caso de uso, diagrama de atividades e diagrama de sequência.

Diagrama de classes: usado para representar graficamente todas as classes contidas no sistema.

Diagrama de caso de uso: Usado para representar graficamente O comportamento dos participantes externos vinculados ao sistema. Atores são aqueles que podem acessar o sistema.

Diagrama de atividades: Usado para demonstrar graficamente o algoritmo e parte do sistema que também pode representar ações das pessoas interagindo com o sistema.

Diagrama de sequência: é utilizado para demostrar de modo gráfico a interação dos atores com os métodos ou operações do sistema.

Modelo entidade e relacionamento: é utilizado para demostrar de modo gráfico o esquema relacional do banco de dados, mostrando os atributos das entidades e seus relacionamentos.

## Diagramas

### Diagramas de classes

![AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image1.png](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image1.png)

### Diagramas de caso de uso

![AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image2.png](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image2.png)

### UC1 – Cadastrar

[Untitled](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/Untitled%20Database%20316858961fe144eca075830b564679ff.csv)

### UC2 – Autenticar

[Untitled](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/Untitled%20Database%2084584ef26946438ba8f710e79c4ece6e.csv)

### UC3 – Pesquisar contato

[Untitled](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/Untitled%20Database%20e0a020e22d4c47729683c4a6df650525.csv)

### UC4 – Incluir contato

[Untitled](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/Untitled%20Database%206135cf4fdeb446b2b41d5434ec9cb915.csv)

### UC5 – Alterar contato

[Untitled](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/Untitled%20Database%20edfb24db7bbc436e9ab79fea2f19108d.csv)

### UC6 – Excluir contato

[Untitled](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/Untitled%20Database%209d07802607f942a7864aa7e197ebfb1e.csv)

### Diagrama de atividade

![AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image3.png](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image3.png)

### Diagrama de sequência

![AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image4.png](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image4.png)

# Protótipo de telas

![AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image5.png](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image5.png)

Figura : Tela de Login

![AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image6.png](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image6.png)

Figura : Tela de cadastro de usuário

![AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image7.png](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image7.png)

Figura : Menu principal

![AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image8.png](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image8.png)

Figura : Editar contato

![AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image9.png](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image9.png)

Figura : Editar dados do usuário

![AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image10.png](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image10.png)

Figura : cadastro de novos contatos

![AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image11.png](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/image11.png)

Figura : Pesquisar contato

# Cronograma

[Untitled](AAP_SGDC%206da2c86f48bf4282b11d530e37e56451/Untitled%20Database%20af6f9dfc6280489caa2d845e3f2afd2e.csv)

# Bibliografia

BRASIL. Executivo. **LEI n. 13709, de 14 de agosto de 2018. DISPÕE SOBRE A PROTEÇÃO DE DADOS PESSOAIS E ALTERA A LEI Nº 12.965, DE 23 DE ABRIL DE 2014 (MARCO CIVIL DA INTERNET).** Diário Judicial Eletrônico. Brasília, 14 de agosto de 2018. Disponível em: [http://www.planalto.gov.br/ccivil_03/_ato2015-2018/2018/Lei/L13709.htm](http://www.planalto.gov.br/ccivil_03/_ato2015-2018/2018/Lei/L13709.htm). Acesso em: 14 jun. 2021.

BRASIL. Legislativo. **LEI n. 12965, de 23 de abril de 2014. ESTABELECE PRINCÍPIOS, GARANTIAS, DIREITOS E DEVERES PARA O USO DA INTERNET NO BRASIL**. Diário Judicial Eletrônico. Brasília, 23 de abril de 2014. Disponível em: [https://www.planalto.gov.br/ccivil_03/_ato2011-2014/2014/lei/l12965.htm](https://www.planalto.gov.br/ccivil_03/_ato2011-2014/2014/lei/l12965.htm). Acesso em: 14 jun. 2021.

CASTELO BRANCO JÚNIOR, Eliseu; DE CASTRO MACHADO, Javam; DA SILVA MONTEIRO FILHO, José Maria. **Estratégias para Proteção da Privacidade de Dados Armazenados na Nuvem**. 2014. 75 p. Dissertação ( Doutorado em Ciências da Computação) - UNIVERSIDADE FEDERAL DO CEARÁ, 2014. Disponível em: https://www.inf.ufpr.br/sbbd-sbsc2014/sbbd/proceedings/artigos/pdfs/14.pdf. Acesso em: 20 mai. 2021.

GOULART, Gil Monteiro ; DE DAVID, Thomaz Delgado . O COMPARTILHAMENTO E ARMAZENAMENTO DE CONTEÚDOS NO ESPAÇO DIGITAL: UMA ANÁLISE ACERCA DA RESPONSABILIDADE DOS PROVEDORES EM FACE DA VIOLAÇÃO DE DIREITOS E GARANTIAS FUNDAMENTAIS. **Seminário internacional de demandas sociais e políticas públicas na sociedade contemporânea**, 2015.

RIBEIRO, Samuel de Oliveira; SILVA, Francisco Airton; VIEIRA, Alex Borges; GONÇALVES, Glauber Dias. **Análise de um Serviço Virtual de Armazenamento em Nuvem Ciente de Padrões de Acesso por Usuários.** *In*: ESCOLA REGIONAL DE COMPUTAÇÃO CEARÁ, MARANHÃO, PIAUÍ (ERCEMAPI), 7. , 2019, São Luís. **Anais** [...]. Porto Alegre: Sociedade Brasileira de Computação, 2019 . p. 238-245.

SOMASUNDARAM, G.; SHRIVASTAVA, Alok; SERVICES, EMC Education. **Armazenamento e Gerenciamento de Informações: Como armazenar, gerenciar e proteger informações digitais**. Bookman Editora, 2009.