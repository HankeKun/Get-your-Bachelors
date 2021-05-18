using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public VectorValue playerStorage;
    public void PlayGame()
    {
        PlayerPrefs.SetInt("QuestState", 1);
        playerStorage.initialValue =  new Vector2(0, 0);
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
