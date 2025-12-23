using UnityEngine;
using System.IO;

public class PlayerData : MonoBehaviour
{
    public MainMenu mainMenu;

    public static PlayerData Instance;

    public string playerName;
    public int highScore;
    public string highScoreHolder;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();
    }

    private void Start()
    {
        mainMenu = GameObject.Find("Canvas").GetComponent<MainMenu>();
    }
   
    public void SetPlayerName(string playerName)
    {

    }
    [System.Serializable]
    class SaveData
    {
        public int highScore;
        public string highScoreHolder;
    }

    public void SaveHighscore()
    {
        SaveData data = new SaveData();
        data.highScore = highScore;
        data.highScoreHolder = highScoreHolder;
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScore = data.highScore;
            highScoreHolder = data.highScoreHolder;
        }
    }
}
