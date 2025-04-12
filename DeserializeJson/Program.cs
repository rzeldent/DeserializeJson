using DeserializeJson;
using System.Drawing;
using System.Text.Json;

var jsonOptions = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true,
    WriteIndented = true,
    ReadCommentHandling = JsonCommentHandling.Skip
};

var json = File.ReadAllText("fat.json");

var fat = JsonSerializer.Deserialize<Fat>(json, jsonOptions);

var @string = fat.Parameters["String"].GetString();
Console.WriteLine($"String: {@string}");

var @float = fat.Parameters["Float"].GetSingle();
Console.WriteLine($"FLoat: {@float}");

var timeout = fat.Parameters["Timeout"].Deserialize<TimeSpan>();
Console.WriteLine($"Timeout: {timeout}");

var size = fat.Parameters["Size"].Deserialize<Size>();
Console.WriteLine($"Size: {size}");
