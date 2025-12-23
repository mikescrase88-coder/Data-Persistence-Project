using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_InputField playerNameInput; 
    public string playerName;

    private void Update()
    {
        playerName = playerNameInput.text;
    }

    public void SavePlayerName()
    {
        PlayerData.Instance.playerName = playerName;
    }
    public void StartGame()
    {
       SceneManager.LoadScene(1);
    }
}
