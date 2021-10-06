<h1 align="center">
  Minha Api Core - Desenvolvedor.io
</h1>
<p align="center">
  🚀 Aplicação Simples de cadastro de Fornecedores
</p>

<p align="center">
  <a href='#tecnologies'>Tecnologias</a> |
  <a href='#funcionalidades'>Funcionalidades </a> |
  <a href='#funcionalidades'>Como Utilizar </a> 
</p>  

## <p id='tecnologies'>💻 Tecnologia </p>

- <a href="https://docs.microsoft.com/pt-br/dotnet/core/dotnet-five">ASP.NET Core 3.1</a>
- <a href="https://docs.microsoft.com/pt-br/ef/core/">EF Core 3.1</a>


## <p id='funcionalidades'>⚙ Funcionalidades</p>

- Listagem, Cadastro, Atualização e Remoção de Fornecedores.

## <p id='utilizar'>💻 Como Utilizar </p>
  - Deve configurar(appsettings.json) o banco para apontar para sua maquina, no código estou utilizando um LocalDb direto no Visual Studio para ser utilizado com SqlServer.
  - No o Visual Studio, você deve digitar no PM Console : <strong> update-database </strong>
  - Para testar API, você pode utilizar o <strong>POSTMAN</strong> e passar URL(https://localhost:44365/api/fornecedores), segue abaixo um JSON para teste.
  ```JSON
  //POST 
  {
    "id": "8b791681-c89f-5b88-a5cc-5354d989cd43",
    "name": "Teste Postman POST",
    "documento": "14236637832",
    "tipoFornecedor": 1,
    "ativo": true
}
  ```
