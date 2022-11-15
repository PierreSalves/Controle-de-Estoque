
<h1 align="center"> Controle de Estoque </h1>

## Sobre : Projeto de controle de estoque com Windows Form
	## Funcionalidades
		- VISUALIZAR
			- [X]Compras de Materiais
			- [X]Materiais
			- [X]Produtos
			- [X]Receitas
			- [X]Produção
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
			- [X]Produção
			- [X]Venda Produtos
	## Desenvolvimento
		* Microsoft.CSharp
		* .NETFramework 4.8
		* Banco de dados SQL SERVER

## Pré-requisitos para executar o projeto
	Antes de começar, você precisa ter instalado em sua máquina as seguintes ferramentas:
	* [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/vs/)
	* [Banco de dados SQL SERVER](https://go.microsoft.com/fwlink/?linkid=866658)
	* [SQL Server Management Studio](https://aka.ms/ssmsfullsetup)

## Começando
	Você precisa clonar este repositório na sua máquina
	* [Clone esse repositório](https://github.com/PierreSalves/CRUD_Winform_CSharp.git)
	* [Baixar Arquivo ZIP](https://github.com/PierreSalves/CRUD_Winform_CSharp/archive/refs/heads/main.zip)

## Configurando o Banco de Dados
	* É preciso criar dez tabelas no Banco de dados SQL
	* Os arquivos .sql estão salvos na pasta "SQL" do projeto

	* 1° Passo - Abra o arquivo "CREATE TABLES.sql" e execute cada comando seguindo a ordem
	* 2° Passo - Abra o arquivo "CREATE_TRIGGER_buyMaterial.sql" e execute
	* 3° Passo - Abra o arquivo "CREATE_TRIGGER_ProduceProduct.sql" e execute
	* 4° Passo - Abra o arquivo "CREATE_TRIGGER_SellProduct.sql" e excecute
	* 5° Passo - Abra o arquivo "INSERT TABLES.sql" e execute o comando INSERT de cada Tabela
	
	* OBSERVAÇÃO : O usuário padrão do sistema é inserido na tabela tblUsers, você precisa inserir o mesmo usuário cadastrado na hora que for fazer login no sistema.
	* usuário : root
	* senha : 0990

## Executando o Projeto
	* Abra a solução "Projeto-Winform.sln" localizado na pasta "Projeto-Winform"
	* Altere todas as strings de conexão com o banco de dados nos Forms:
		*frmLoginUser
		<img src="https://github.com/Lucas-Casarotti/Teste01/blob/main/Conectando%20no%20banco/DataSource.png" align="left" alt="Data Source">
	
	* Após ter conectado o banco de dados corretamente
	* Inicie o projeto
	* Aguarde alguns segundos até projeto ser executado