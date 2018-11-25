using System.IO;
using static System.IO.Directory;
using Newtonsoft.Json;

namespace TutDiscordBot.DataStorage.Implementations
{
    public class JsonStorage : IDataStorage
    {
        public void StoreObject(object obj, string key)
        {
            var file = $"{key}.json";
            CreateDirectory(Path.GetDirectoryName(file));
            var json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(file ,json);
        }

        public T RestoreObject<T>(string key)
        {
            var json = File.ReadAllText($"{key}.json");

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}