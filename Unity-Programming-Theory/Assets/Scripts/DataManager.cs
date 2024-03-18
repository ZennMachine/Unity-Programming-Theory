using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public int hiScore;
    public int currentVehicleID;
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
    public class GameData
    {
        public int hiScore;
        public int currentVehicleID;
    }

    public void SaveData()
    {
        GameData data = new GameData();
        data.hiScore = hiScore;
        data.currentVehicleID = currentVehicleID;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            GameData data = JsonUtility.FromJson<GameData>(json);

            hiScore = data.hiScore;
            currentVehicleID = data.currentVehicleID;
        }
    }
}
