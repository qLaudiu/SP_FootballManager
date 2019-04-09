using System;
using System.IO;
using Newtonsoft.Json;

namespace SP_FootballManager
{
    public abstract class RequestCommand<T>
    {
        protected string PLAYER_JSON_FILE = "../../../players_db.json";

        protected string TEAM_DETAILS_FILE = "../../../team_details_db.json";

        public abstract T execute();

        protected string SerializeObject(Object obj)
        {
            if (obj == null)
            {
                return "";
            }
            else
            {
                return JsonConvert.SerializeObject(obj);
            }
        }

        protected T DeserializeObject(string obj)
        {
            if (obj == null)
            {
                throw new Exception();
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(obj);
            }
        }

        protected bool IsFileAvailalble(string fileName)
        {
            return File.Exists(fileName);
        }

        protected void CreateFileIfNeeded(string fileName)
        {
            if (!IsFileAvailalble(fileName))
            {
                CreateFile(fileName);
            }
        }

        private void CreateFile(string fileName)
        {
            var file = File.Create(fileName);
            file.Close();
        }

        private void DeleteFile(string fileName)
        {
            File.Delete(fileName);
        }

        protected void WriteToFile(string fileName, string text)
        {
            File.WriteAllText(fileName, text);
        }

        protected string GetTextFromFile(string fileName)
        {
            
            StreamReader s = new StreamReader(fileName);
            var stream = s.ReadToEnd();
            s.Close();
            return stream;
        }
    }
}
