using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor;
using UnityEngine.Android;

public class MainMenu : MonoBehaviour
{
    public TMP_InputField playerNameInput; 
    public string playerName;

    private void Update()
    {
        playerName = playerNameInput.text;
        SavePlayerName();
    }

    public void SavePlayerName()
    {
        PlayerData.Instance.playerName = playerName;
    }
    public void StartGame()
    {
       SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        PlayerData.Instance.SaveHighscore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
