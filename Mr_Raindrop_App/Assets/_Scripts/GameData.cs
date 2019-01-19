
[System.Serializable]
public class GameData
{
    public  int highScore;
    public  int CoinAmount;
    public  string PlayerPrefabName;
    public  string MainPrefabName;

    public GameData(int ScoreInt, int CoinInt, string PlayName, string MainName)
    {
        highScore = ScoreInt;
        CoinAmount = CoinInt;
        PlayerPrefabName = PlayName;
        MainPrefabName = MainName;
    }
}
