# Technical Challenge

## Calculo para decompor um número em todos os seus divisores, enumerando também aqueles que forem primos.

Tabela de conteúdos
=================
<!--ts-->
   * [Tecnologias](#Tecnologias)
   * [Biblioteca](#biblioteca)
   * [Testes](#testes)
   * [Console](#console)
   * [API](#api)
<!--te-->

## 🛠 Tecnologias
============

- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [xUnit](https://xunit.net/)
- [.NET CORE 3.1](https://dotnet.microsoft.com/download/dotnet/3.1)

## Biblioteca
============
Projeto Base.Calculo onde se encontra o cálculo realizado para retorno dos divisores e divisores primos que compõem o número informado.

## Testes
============
Projeto Test.Calculo realiza os testes diretamente na biblioteca, validando o calculo realizado.
- DeveRetornarNumerosDivisores
- DeveRetornarNumerosPrimos

## Console
============
Projeto Comando.Calculo, console para informar o número a ser calculado.

## API
============
Projeto Api.Calculo é o serviço criado para utilização por diversos sistemas.

### Swagger

`/index.html`

### Request

`GET /api/v1/calculo/{numero}`

### Sucess Response

    Status: 200 OK
    
	{
		"numerosDivisores": [1,3,5,9,15,45],
		"numerosPrimos": [1,3,5]
	}
	
### Erro Response	

Status: 500 InternalServerError
    
	{
		"Message": "string",
		"Details": "string"
	}