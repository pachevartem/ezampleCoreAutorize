using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VRAutorization.Calsses
{
    /// <summary>
    /// Перенести данные из JSON в ItemdataBase
    /// </summary>
    public class Worker
    {
        private string pathDatabase;
        public List<itemDataBase> JsonDataBase = new List<itemDataBase>();

        public Worker()
        {
            GetPath();
            ParseJsonObject();
        }

        string GetPath()
        {
            pathDatabase = Path.Combine(Directory.GetCurrentDirectory(), "Res", "database.json");
            return pathDatabase;
        }

        void ParseJsonObject()
        {
            string _file;

            using (StreamReader sr = new StreamReader(pathDatabase))
            {
                _file = sr.ReadToEnd();
            }


            JsonDataBase = Newtonsoft.Json.JsonConvert.DeserializeObject<List<itemDataBase>>(_file);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var dataBase in JsonDataBase)
            {
                sb.AppendLine($"Почта пользователя - {dataBase.email}, пароль - {dataBase.password}");
            }

            return sb.ToString();
        }
    }
}