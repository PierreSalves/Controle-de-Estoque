
<h1 align="center"> Controle de Estoque </h1>

## Sobre: 
� um projeto de sistema Desktop no C# com SQL SERVER, o sistema emula um controle de estoque de materiais e produtos de uma padaria, com a entrada de materiais, produ��o e sa�da de produtos.

## Funcionalidades
**VISUALIZAR**
- [x] Compras de Materiais
- [x] Materiais
- [x] Produtos
- [x] Receitas
- [x] Produ��o
- [x] Vendas de Produtos
- [x] Estoque
**CADASTRAR**
- [x] Materiais
- [x] Produtos
- [x] Receitas
**EDITAR**
- [x] Materiais
- [x] Produtos
- [x] Receitas
**EXCLUIR**
- [x] Materiais
- [x] Produtos
- [x] Receitas
**EFETUAR**
- [x] Compras de Materiais
- [x] Produ��o
- [x] Venda Produtos

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
	**usu�rio : root** /
	**senha : 0990**

## Executando o Projeto
* Abra a solu��o "Projeto-Winform.sln" localizado na pasta "Projeto-Winform"
* Altere todas as strings de conex�o com o banco de dados em todos os forms
* Form de Login <img src="https://github.com/PierreSalves/CRUD_Winform_CSharp/blob/main/Projeto-Winform/Prints/String_de_conex%C3%A3o_frmLoginUser.png?raw=true" align="left" alt="ConnectionString frmLoginUser">
* Demais Forms <img src="https://github.com/PierreSalves/CRUD_Winform_CSharp/blob/main/Projeto-Winform/Prints/String_de_conex%C3%A3o_frmCadastroRawMaterial.png?raw=true" align="left" alt="ConnectionString frmCadastroRawMaterial">
* Ap�s ter conectado o banco de dados corretamente
* Inicie o projeto
* Aguarde alguns segundos at� projeto ser executado

## Autor
**Pierre Sanches Alves**
