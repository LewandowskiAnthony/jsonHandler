using System;
using System.IO;
using System.Security;

namespace jsonManipulation
{
    public class jsonHandler
    {
        private String jsonPath;
        private String usedJson;

        public jsonHandler()
        {
            this.jsonPath = "";
        }

        public jsonHandler(string jsonPath)
        {
            this.jsonPath = jsonPath;
        }

        public String readJsonFile()
        {
            using (var reader = new StreamReader(jsonPath))
            {
                this.usedJson = reader.ReadToEnd();
                return this.usedJson;
            }
        }

        public String replaceAttributeNameInJson(String wordToReplace, String remplacementWord)
        {
            String replacement = usedJson.Replace("\"" + wordToReplace + "\"" + " : ", "\"" + remplacementWord + "\"" + " : ");
            replacement = replacement.Replace(wordToReplace + ":", remplacementWord + ":");
            usedJson = replacement;
            return usedJson;
        }

        public void suppressAttributeInJson()
        {

        }

        public void exportJson(String _filePath, String _fileName)
        {
            String fullPath = @"" + _filePath + "\\" + _fileName + ".json";
            File.Create(fullPath).Close();
            try
                {
                    File.WriteAllText(fullPath, usedJson);
                }
                catch (SecurityException ex)
                {
                    //present dialog
                }
                catch (Exception ex)
                {
                    //All other exceptions handled the same
                }
        }

        public string getJsonPath { get { return jsonPath; } set {;} }
    }
}
