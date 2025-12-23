using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;
    public MainMenu mainMenu;
    public string playerName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        mainMenu = GameObject.Find("Canvas").GetComponent<MainMenu>();
    }
   
    public void PlayerNameSet(string playerName)
    {

    }
}
