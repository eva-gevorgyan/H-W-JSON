using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonFIles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.json";
            var txt = new { Name = "John", Age = 24 };
            var newtxt = new { ID = 5845, Password = 1221 };
            string json = JsonSerializer.Serialize(txt);
            string content = json;
            FileStream fileStream = new FileStream(filePath, FileMode.Create);

            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(content);
            streamWriter.WriteLine(JsonSerializer.Serialize(newtxt));
            streamWriter.Close();
            fileStream.Close();

            StreamReader streamReader = new StreamReader(filePath);
            string read=streamReader.ReadToEnd();
            Console.WriteLine(read);


            //string filePath = "example.txt";
            //string content = "Hello, world!";
            //FileInfo fileInfo = new FileInfo(filePath);
            //if (!fileInfo.Exists)
            //{
            //    using (StreamWriter streamWriter = fileInfo.CreateText())
            //    {
            //        streamWriter.WriteLine(content);
            //    }
            //}
        }
    }
}