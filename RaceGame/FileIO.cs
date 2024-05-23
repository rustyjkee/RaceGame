namespace Race
{
    public class FileIO
    {
        public static string Read(string filePath)
        {
            using (FileStream fStream = new FileStream(filePath, FileMode.OpenOrCreate))
            using (StreamReader sr = new StreamReader(fStream))
                return sr.ReadToEnd();
        }

        public static void Write(string data, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
                sw.Write(data);
        }

        public static void Append(string data, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
                sw.Write(data);
        }
    }
}
