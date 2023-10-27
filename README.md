# Gerenciador de Not�cias


OBSERVA��ES:

* Optei por n�o alterar a estrutura principal do projeto mas recomendo que seja criado um projeto espec�fico para entidades do dom�nio independente do projeto Dados (Persistencia).
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

