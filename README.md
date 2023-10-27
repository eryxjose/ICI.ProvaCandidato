# Gerenciador de Notícias


OBSERVAÇÕES:

<<<<<<< Updated upstream
* Optei por não alterar a estrutura principal do projeto mas recomendo que seja criado um projeto específico para entidades do domínio independente do projeto Dados (Persistencia).
=======
* A branch 'master' contém a versão inicial com todas as funcionalidades solicitadas sem utilizar a camada de aplicação ('ICI.ProvaCanditado.Negocio').
* A branch 'cqrs_camada_negocio' implementa o padrão CQRS/MediatoR para acesso aos serviços da camada de aplicação ('ICI.ProvaCanditado.Negocio').
* * Optei por não alterar a estrutura principal do projeto mas recomendo a implementação da camada de domínio. 
	* específico para entidades do domínio independe do projeto Dados (Persistencia).
>>>>>>> Stashed changes
* Optei por utilizar sqlite inicialmente para simplificar a entrega da versão inicial. Instale um cliente sqlite para visualizar a base de dados.
  * Instale o [Cliente SQLiteBrowser](https://sqlitebrowser.org/dl/)
  * Execute o cliente sqlite
  * Selecione 'Arquivo > Abrir banco de dados' para exibir a caixa de diálogo 'Escolha um arquivo do banco de dados'
  * Navegue para pasta do projeto 'ICI.ProvaCandidato.Web' e selecione o arquivo 'gerenciadornoticias.db'
* Optei por não alterar o tipo do identificador 'Id' mas recomendo que seja alterado para string para reduzir a dependência entre frontend e backend ao permitir a criação de identificadores do tipo Guid no frontend.
* No meu entendimento, a estrutura fornecida objetiva verificar meus conhecimentos relacionados ao uso da tecnologia Razor para o frontend em uma aplicação asp.net mvc.
* Recomendo adotar o padrão BEM (Block Element Modifier) para estilização da aplicação.

ATIVIDADES:

* Barra de Ferramentas 
  * Criado estilo '.action-toolbar' para formatação barra de ferramentas inline utilizada em tabelas para ações de editar, excluir, etc.
  * Utilizado elemento 'ol' para melhorar a acessibilidade da barra de ferramentas inline.
  * 

REFERÊNCIAS:

* [jQuery DataTable](https://datatables.net/)
* [Bootbox](https://bootboxjs.com/)
* [fontawesome](https://fontawesome.com/icons)


# A separação entre as camadas domain e persistence promove os seguintes benefícios:

Isolamento do domínio: A camada de domínio fica isolada dos detalhes de implementação da camada de persistência. Isso torna o domínio mais fácil de entender, testar e manter.
Flexibilidade: A camada de persistência pode ser alterada sem afetar o domínio. Isso permite que a aplicação seja adaptada a diferentes tecnologias de persistência.
Testabilidade: A camada de domínio pode ser testada independentemente da camada de persistência. Isso torna mais fácil garantir a qualidade do domínio.

Aqui estão alguns argumentos específicos para manter as duas camadas separadas:

A camada de domínio deve representar o domínio do negócio, não a implementação da persistência. As entidades de domínio devem ser modeladas de acordo com as necessidades do negócio, não com os requisitos da camada de persistência.
A camada de persistência deve ser responsável por gerenciar a persistência dos dados, não pela lógica de negócio. A lógica de negócio deve ser implementada na camada de domínio, não na camada de persistência.
A camada de persistência deve ser abstrata da camada de domínio. A camada de domínio não deve depender da implementação específica da camada de persistência.


