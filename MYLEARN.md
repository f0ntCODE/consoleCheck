# O que aprendi com esse projeto

> Nota: Este documento está sendo preenchido ao longo do desenvolvimento desse projeto. Pode ser que esteja incompleto nesse momento. Aguarde mais atualizações!

## Criando um projeto via console

Fiz alguns testes localmente antes de criar este repositório e aprendi alguns comandos de terminal para criar projetos de console facilmente:
- ``dotnet new console``: Criar um novo projeto console dentro da pasta;

- ``dotnet build --output ./<nome_da_pasta>``: O nome da pasta onde irá gerar o arquivo *.dll* (explicarei depois);
- ``dotnet ./<arquivo>.dll``: Executar o programa de terminal criado;

## Uso de classes

Neste projeto estou criando classes em um só arquivo (junto com o ``Main``) por questões de simplicidade. Irei aumentar a complexidade com o tempo. Mas, já observei alguma particularidades:

- *Fields*: São variáveis que representam as propriedades de uma classe
  - Convenção: *_camelCase*;
  - Modificador típico: *private*;
- *Properties*: São métodos que controlam acesso, consulta e modificação da respectiva *field*, mas podem existir sem elas.
  - Convenção: *PascalCase*;
  - Modificador típico: *public*

### Palavra-chave *Override*
Diferentemente do java, que usamos uma notação ``@Override``, no C# declaramos explicitamente a palavra ``Override`` na declaração do método, como no ``ToString()`` personalizado que criei na classe ``Task``.
