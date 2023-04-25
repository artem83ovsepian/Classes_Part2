using System.Text.Json;
using HW5.App_Data;

namespace HW5.Add_Data
{
    public class JSONDb
    {
        private readonly string fileName = "App_Data\\db.json";
        

        public RootDb DbRoot { get; set; }

        public JSONDb()
        {
            DbRoot = JsonSerializer.Deserialize<RootDb>(File.ReadAllText(fileName));
        }

        public void Save()
        {
            var jsonText = JsonSerializer.Serialize(DbRoot);
            File.WriteAllText(fileName, jsonText);
        }
    }
}
