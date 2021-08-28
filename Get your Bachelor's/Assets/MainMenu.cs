using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public GameObject yesNo;
    public VectorValue playerStorage;
    public UnityEngine.UI.Button playButton;
    public UnityEngine.UI.Button optionsButton;
    public UnityEngine.UI.Button quitButton;
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

    public void ResetGame() {
        playButton.interactable = false;
        optionsButton.interactable = false;
        quitButton.interactable = false;
        yesNo.SetActive(true);
    }

    public void YesButton() {
        PlayerPrefs.SetInt("Ended", 1);
        yesNo.SetActive(false);
        playButton.interactable = true;
        optionsButton.interactable = true;
        quitButton.interactable = true;
    }

    public void NoButton() {
        yesNo.SetActive(false);
        playButton.interactable = true;
        optionsButton.interactable = true;
        quitButton.interactable = true;
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
