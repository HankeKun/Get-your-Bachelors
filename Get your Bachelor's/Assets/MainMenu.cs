using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public VectorValue playerStorage;
    public void PlayGame()
    {
        if (PlayerPrefs.GetInt("Ended", 1) == 1)
        {
            PlayerPrefs.SetInt("Ended", 0);
            PlayerPrefs.SetInt("QuestState", 1);
            playerStorage.initialValue =  new Vector2(0, 0);
            SceneManager.LoadScene(2);
        } 
        else
        {
            float x = PlayerPrefs.GetFloat("X", 0);
            float y = PlayerPrefs.GetFloat("Y", 0);
            playerStorage.initialValue =  new Vector2(x, y);
            SceneManager.LoadScene(PlayerPrefs.GetInt("Scene", 2));
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
