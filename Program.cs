using System.Text;
// using System.Text.Json;// using System.Text.Json.Serialization;


using JsonStream.src;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
using (FileStream file = File.Open("json.txt", FileMode.Open)){
   
   IAsyncEnumerable<Dados> dados = JsonSerializer.DeserializeAsyncEnumerable<Dados>(file);
   
   await foreach (Dados dado in dados) {
        Console.WriteLine(dado.ToString());
        Console.WriteLine();
        Console.ReadLine();
   }
}
*/
/*
var options = new JsonReaderOptions
{
    AllowTrailingCommas = true,
    CommentHandling = JsonCommentHandling.Skip
};

ReadOnlySequence<Dados> jsonReadOnly = ReadOnlySequence<Dados>();
// File.ReadAllBytes( @"C:\Users\Thieg\projeto\.net\JsonStream\json.txt");
var reader = new Utf8JsonReader( jsonReadOnly, options);
*/

JsonSerializer serializer = new JsonSerializer();
using (FileStream file = File.Open("Acordos_Full-01.json", FileMode.Open)){
    using (StreamReader stream = new StreamReader(file)) {
        using (JsonTextReader reader = new JsonTextReader(stream)) {
            while (reader.Read()){

                // Dados dados = JsonSerializer.Deserialize<Dados>(reader.GetString);
                if (reader.TokenType == JsonToken.StartObject){

                    HistoriasRecovery dados = serializer.Deserialize<HistoriasRecovery>(reader);

                    Console.WriteLine(dados.ToString());
                 }
            }
        }
    }

    Console.ReadLine();
}

