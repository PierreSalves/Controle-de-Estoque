
<h1 align="center"> Controle de Estoque </h1>

## Sobre : Projeto de controle de estoque com Windows Form
	## Funcionalidades
		- VISUALIZAR
			- [X]Compras de Materiais
			- [X]Materiais
			- [X]Produtos
			- [X]Receitas
			- [X]Produ��o
			- [X]Vendas de Produtos
			- [X]Estoque
		- CADASTRAR
			- [X]Materiais
			- [X]Produtos
			- [X]Receitas
		- EDITAR
			- [X]Materiais
			- [X]Produtos
			- [X]Receitas
		- EXCLUIR
			- [X]Materiais
			- [X]Produtos
			- [X]Receitas
		- EFETUAR
			- [X]Compras de Materiais
			- [X]Produ��o
			- [X]Venda Produtos
	## Desenvolvimento
		* Microsoft.CSharp
		* .NETFramework 4.8
		* Banco de dados SQL SERVER

## Pr�-requisitos para executar o projeto
	Antes de come�ar, voc� precisa ter instalado em sua m�quina as seguintes ferramentas:
	* [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/vs/)
	* [Banco de dados SQL SERVER](https://go.microsoft.com/fwlink/?linkid=866658)
	* [SQL Server Management Studio](https://aka.ms/ssmsfullsetup)

## Come�ando
	Voc� precisa clonar este reposit�rio na sua m�quina
	* [Clone esse reposit�rio](https://github.com/PierreSalves/CRUD_Winform_CSharp.git)
	* [Baixar Arquivo ZIP](https://github.com/PierreSalves/CRUD_Winform_CSharp/archive/refs/heads/main.zip)

## Configurando o Banco de Dados
	* � preciso criar dez tabelas no Banco de dados SQL
	* Os arquivos .sql est�o salvos na pasta "SQL" do projeto

	* 1� Passo - Abra o arquivo "CREATE TABLES.sql" e execute cada comando seguindo a ordem
	* 2� Passo - Abra o arquivo "CREATE_TRIGGER_buyMaterial.sql" e execute
	* 3� Passo - Abra o arquivo "CREATE_TRIGGER_ProduceProduct.sql" e execute
	* 4� Passo - Abra o arquivo "CREATE_TRIGGER_SellProduct.sql" e excecute
	* 5� Passo - Abra o arquivo "INSERT TABLES.sql" e execute o comando INSERT de cada Tabela
	
	* OBSERVA��O : O usu�rio padr�o do sistema � inserido na tabela tblUsers, voc� precisa inserir o mesmo usu�rio cadastrado na hora que for fazer login no sistema.
	* usu�rio : root
	* senha : 0990

## Executando o Projeto
	* Abra a solu��o "Projeto-Winform.sln" localizado na pasta "Projeto-Winform"
	* Altere todas as strings de conex�o com o banco de dados nos Forms:
		*frmLoginUser
		<img src="https://github.com/Lucas-Casarotti/Teste01/blob/main/Conectando%20no%20banco/DataSource.png" align="left" alt="Data Source">
	
	* Ap�s ter conectado o banco de dados corretamente
	* Inicie o projeto
	* Aguarde alguns segundos at� projeto ser executado