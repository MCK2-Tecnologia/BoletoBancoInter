# BoletoBancoInter
Backend API para cadastro, exibição e geração do PDF de boletos do banco inter em .Net Core.

### Geração do Certificado

Execute 1 dos comandos abaixo para gerar os arquivos key e csr

```sh
$ openssl req -newkey rsa:2048 -keyout seudominio.com.br.key -out seudominio.com.br.csr
```

ou

```sh
$ openssl req -new -newkey rsa:2048 -nodes -keyout seudominio.com.br.key -out seudominio.com.br.csr
```

Arquivos Gerados:

- seudominio.com.br.key: gerado no momento da criação das chaves
- certificado.crt: Download no internet banking do banco inter

**NESTA ETAPA FAÇA OS DEVIDOS TRÂMITES JUNTO AO BANCO INTER, EM SEGUIDA ACESSE O INTERNET BANKING E BAIXE O ARQUIVO certificado.crt**

Faça a geração do arquivo pfx que será necessário para autenticação na API.

```sh
$ openssl pkcs12 -export -out seudominio.com.br.pfx -inkey seudominio.com.br.key -in certificado.crt
```

### Aplicação
No diretório raiz da aplicação você vai encontrar um diretório com o nome **Services**, nele contém um arquivo chamado **BoletoService.cs**, abra em um editor de texto de sua preferência, e faça as seguintes alterações:

 - Altere os lugares onde contém o caminho do certificado **/opt/mck2.com.br.pfx** para o diretório onde você gerou seu arquivo pfx.
 - Altere os trechos do código onde está **<senha_certificado>** para a senha que você informou no momento da geração do seu certificado.
 - Altere os lugares onde contém o texto **<conta_bancaria>** para o número da sua conta bancária **COM DÍGITO E SEM O SEPARADOR -**.


### Execução
No diretório Helpers existe uma classe chamada BoletoTeste (BoletoTeste.cs), ali existem informações de demostração para você preencher seus boletos de teste, atualmente o endpoint de cadastro não está pegando as informações enviadas pela requisição **(Implementarei em breve)**.

Execute a aplicação:

```sh
$ dotnet restore
$ dotnet build
$ dotnet run
```

Acesse o ***swagger*** para testes dos endpoints:

http://localhost:5010/swagger/index.html

## Próximas atualizações
15/12/2020 - Listagem de boletos