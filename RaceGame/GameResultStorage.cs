namespace Race
{
    public class GameResultStorage
    {

        private const string resultsPath = "results.json";

        public static void Save(GameResult result)
        {
            try
            {
                var results = GetAll() ?? new List<GameResult>();
                results.Add(result);

                var jsonText = JSON.Serialize<List<GameResult>>(results);
                FileIO.Write(jsonText, resultsPath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static List<GameResult> GetAll()
        {
            try
            {
                return JSON.Deserialize<List<GameResult>>(FileIO.Read(resultsPath));
            }
            catch
            {
                return new List<GameResult>();
            }
        }
    }
}
