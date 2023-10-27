# Gerenciador de Not�cias


OBSERVA��ES:

<<<<<<< Updated upstream
* Optei por n�o alterar a estrutura principal do projeto mas recomendo que seja criado um projeto espec�fico para entidades do dom�nio independente do projeto Dados (Persistencia).
=======
* A branch 'master' cont�m a vers�o inicial com todas as funcionalidades solicitadas sem utilizar a camada de aplica��o ('ICI.ProvaCanditado.Negocio').
* A branch 'cqrs_camada_negocio' implementa o padr�o CQRS/MediatoR para acesso aos servi�os da camada de aplica��o ('ICI.ProvaCanditado.Negocio').
* * Optei por n�o alterar a estrutura principal do projeto mas recomendo a implementa��o da camada de dom�nio. 
	* espec�fico para entidades do dom�nio independe do projeto Dados (Persistencia).
>>>>>>> Stashed changes
* Optei por utilizar sqlite inicialmente para simplificar a entrega da vers�o inicial. Instale um cliente sqlite para visualizar a base de dados.
  * Instale o [Cliente SQLiteBrowser](https://sqlitebrowser.org/dl/)
  * Execute o cliente sqlite
  * Selecione 'Arquivo > Abrir banco de dados' para exibir a caixa de di�logo 'Escolha um arquivo do banco de dados'
  * Navegue para pasta do projeto 'ICI.ProvaCandidato.Web' e selecione o arquivo 'gerenciadornoticias.db'
* Optei por n�o alterar o tipo do identificador 'Id' mas recomendo que seja alterado para string para reduzir a depend�ncia entre frontend e backend ao permitir a cria��o de identificadores do tipo Guid no frontend.
* No meu entendimento, a estrutura fornecida objetiva verificar meus conhecimentos relacionados ao uso da tecnologia Razor para o frontend em uma aplica��o asp.net mvc.
* Recomendo adotar o padr�o BEM (Block Element Modifier) para estiliza��o da aplica��o.

ATIVIDADES:

* Barra de Ferramentas 
  * Criado estilo '.action-toolbar' para formata��o barra de ferramentas inline utilizada em tabelas para a��es de editar, excluir, etc.
  * Utilizado elemento 'ol' para melhorar a acessibilidade da barra de ferramentas inline.
  * 

REFER�NCIAS:

* [jQuery DataTable](https://datatables.net/)
* [Bootbox](https://bootboxjs.com/)
* [fontawesome](https://fontawesome.com/icons)


# A separa��o entre as camadas domain e persistence promove os seguintes benef�cios:

Isolamento do dom�nio: A camada de dom�nio fica isolada dos detalhes de implementa��o da camada de persist�ncia. Isso torna o dom�nio mais f�cil de entender, testar e manter.
Flexibilidade: A camada de persist�ncia pode ser alterada sem afetar o dom�nio. Isso permite que a aplica��o seja adaptada a diferentes tecnologias de persist�ncia.
Testabilidade: A camada de dom�nio pode ser testada independentemente da camada de persist�ncia. Isso torna mais f�cil garantir a qualidade do dom�nio.

Aqui est�o alguns argumentos espec�ficos para manter as duas camadas separadas:

A camada de dom�nio deve representar o dom�nio do neg�cio, n�o a implementa��o da persist�ncia. As entidades de dom�nio devem ser modeladas de acordo com as necessidades do neg�cio, n�o com os requisitos da camada de persist�ncia.
A camada de persist�ncia deve ser respons�vel por gerenciar a persist�ncia dos dados, n�o pela l�gica de neg�cio. A l�gica de neg�cio deve ser implementada na camada de dom�nio, n�o na camada de persist�ncia.
A camada de persist�ncia deve ser abstrata da camada de dom�nio. A camada de dom�nio n�o deve depender da implementa��o espec�fica da camada de persist�ncia.


