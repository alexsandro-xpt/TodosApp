# TodosApp

### Para executar o back-end é necessario executar seguintes passos:

1. Criar um banco de dados com nome `ProvaTodos` usando o SQL Server de desenvolvimento `(localdb)\MSSQLLocalDB`.
2. Entrar na pasta `src/ProvaTodos.Infrastructure` e executar `dotnet ef -s ..\ProvaTodos.Api\ database update -v` para criar o bando de dados.
3. Entrar na pasta `src/ProvaTodos.Api` e executar `dotnet run` para iniciar a API em http://localhost:5444/api/account.

#### Para testar a API usando jQuery:
##### Listar todos Usuários.
```javascript
var settings = {
  "async": true,
  "crossDomain": true,
  "url": "http://localhost:5444/api/account",
  "method": "GET",
  "headers": {
    "Cache-Control": "no-cache"
  }
}

$.ajax(settings).done(function (response) {
  console.log(response);
});
```

##### Criar um novo Usuário.
```javascript
var settings = {
  "async": true,
  "crossDomain": true,
  "url": "http://localhost:5444/api/account",
  "method": "POST",
  "headers": {
    "Content-Type": "application/json",
    "Cache-Control": "no-cache"
  },
  "processData": false,
  "data": "{\n\t\"nome\": \"Alex\",\n\t\"email\": \"test@teste.com.br\",\n\t\"login\": \"testelogin\",\n\t\"senha\": \"12345\"\n}"
}

$.ajax(settings).done(function (response) {
  console.log(response);
});
```


##### Para editar um Usuário.
```javascript
var settings = {
  "async": true,
  "crossDomain": true,
  "url": "http://localhost:5444/api/account/1",
  "method": "PUT",
  "headers": {
    "Content-Type": "application/json",
    "Cache-Control": "no-cache"
  },
  "processData": false,
  "data": "{\n\t\"nome\": \"Maria\",\n\t\"email\": \"maria@teste.com.br\",\n\t\"login\": \"Maria\",\n\t\"senha\": \"12345\"\n}"
}

$.ajax(settings).done(function (response) {
  console.log(response);
});
```

##### Para excluir um Usuário.
```javascript
var settings = {
  "async": true,
  "crossDomain": true,
  "url": "http://localhost:5444/api/account/2",
  "method": "DELETE",
  "headers": {
    "Cache-Control": "no-cache"
  }
}

$.ajax(settings).done(function (response) {
  console.log(response);
});
```





### Para executar o front-end é necessario executar seguintes passos:

1. Entrar na pasta `src/ProvaTodos.Angular` e executar `npm install` para instalar as dependências.
2. E em seguida `ng serve --open` para iniciar a app em http://localhost:4200/.


