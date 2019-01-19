using System.Collections;
using System.Collections.Generic; // Allows for use of Lists
using System.Runtime.Serialization.Formatters.Binary; // use OS Serialization capabilities
using System.IO; //In Out Toallow for read and write to file 
using UnityEngine;

public class SaveAndLoad : MonoBehaviour
{
    public static int CurrentScore = 0;
    public static int CurrentCoin = 0;
    public static string CurrentPlayName = "MrRaindropPlayer";
    public static string CurrentMainName = "MrRaindrop";

    private void Start()
    {
        SaveFile();
        LoadFile();
    }

    public static void SaveFile()
    {
        string destination = Application.persistentDataPath + "/Save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);

        GameData data = new GameData(CurrentScore, CurrentCoin, CurrentPlayName, CurrentMainName);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
    }

    public static void LoadFile()
    {
        string destination = Application.persistentDataPath + "/Save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenRead(destination);
        else { Debug.LogError("File Not Found"); return; }

        BinaryFormatter bf = new BinaryFormatter();
        GameData data = (GameData)bf.Deserialize(file);
        file.Close();

        CurrentScore = data.highScore;
        CurrentCoin = data.CoinAmount;
        CurrentPlayName = data.PlayerPrefabName;
        CurrentMainName = data.MainPrefabName;

        Debug.Log("HighScore: "+ data.highScore);
        Debug.Log("CoinScore: "+ data.CoinAmount);
        Debug.Log(data.PlayerPrefabName);
        Debug.Log(data.MainPrefabName);

    }
}
