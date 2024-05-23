using System.Text.Json;

namespace Race
{
    internal class JSON
    {
        public static string Serialize<T>(T value)
        {
            var result = string.Empty;

            try
            {
                result = JsonSerializer.Serialize<T>(value);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка: \r\n" + e.Message);
            }

            return result;
        }
        public static T Deserialize<T>(string text)
        {
            var value = default(T);

            try
            {
                value = JsonSerializer.Deserialize<T>(text);
            }
            catch (Exception e)
            {
                //MessageBox.Show("Ошибка: \r\n" + e.Message);
            }

            return value;
        }
    }
}
