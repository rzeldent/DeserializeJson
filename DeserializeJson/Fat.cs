using System.Text.Json;

namespace DeserializeJson
{
    internal struct Fat
    {
        public string Process { get; set; }
        public Dictionary<string, JsonElement> Parameters { get; set; }
    }
}
