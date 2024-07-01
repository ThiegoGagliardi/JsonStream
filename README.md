# Projeto: Leitura Eficiente de JSON com FileStream e JsonStream

## Descrição

Este projeto demonstra como ler arquivos JSON grandes de forma eficiente em memória limitada utilizando C# com .NET, JsonStream e Newtonsoft.Json. A abordagem principal é usar `FileStream` para ler os dados em blocos, em vez de carregar todo o arquivo na memória de uma vez.

## Funcionalidades

- **Leitura de JSON em blocos:** Utiliza `FileStream` para ler grandes arquivos JSON em pequenos blocos.
- **Deserialização eficiente:** Utiliza `JsonStream` e `Newtonsoft.Json` para deserializar dados JSON de forma eficiente.
- **Processamento contínuo:** Processa os dados enquanto lê, economizando memória e melhorando a eficiência.

## Requisitos

- .NET 6.0 ou superior
- Newtonsoft.Json 13.0.1 ou superior
- JsonStream 1.2.0 ou superior

## Instalação

1. Clone o repositório:

   ```bash
   git clone https://github.com/ThiegoGagliardi/JsonStream.git
   cd seu-repositorio
   ```

2. Restaure os pacotes NuGet:

   ```bash
   dotnet restore
   ```

3. Compile o projeto:

   ```bash
   dotnet build
   ```

### Exemplo de Código

#### Program.cs

```csharp
using System;
using System.IO;
using Newtonsoft.Json;
using JsonStream;

namespace LeituraEficienteJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "caminho/para/seu/arquivo.json";

            using FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using StreamReader sr = new StreamReader(fs);
            using JsonTextReader jtr = new JsonTextReader(sr);

            JsonSerializer serializer = new JsonSerializer();
            while (jtr.Read())
            {
                if (jtr.TokenType == JsonToken.StartObject)
                {
                    var obj = serializer.Deserialize<MyJsonObject>(jtr);
                    ProcessObject(obj);
                }
            }
        }

        static void ProcessObject(MyJsonObject obj)
        {
            // Lógica para processar cada objeto JSON
            Console.WriteLine(obj.ToString());
        }
    }

    class MyJsonObject
    {
        // Propriedades do objeto JSON
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}";
        }
    }
}
```
