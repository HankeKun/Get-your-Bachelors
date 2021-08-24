﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameMenu : MonoBehaviour
{
    public GameObject saveButton;
    public GameObject cancelButton;
    public GameObject quitButton;
    public GameObject background;
    public PlayerMovement playerMovement;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !saveButton.activeInHierarchy && (playerMovement.pState == PlayerState.walk))
        {
            playerMovement.pState = PlayerState.gamemenu;
            saveButton.SetActive(true);
            cancelButton.SetActive(true);
            quitButton.SetActive(true);
            background.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && saveButton.activeInHierarchy)
        {
            playerMovement.pState = PlayerState.walk;
            saveButton.SetActive(false);
            cancelButton.SetActive(false);
            quitButton.SetActive(false);
            background.SetActive(false);
        }

    }

    public void SaveButton() {
        PlayerPrefs.SetFloat("X", playerMovement.transform.position.x);
        PlayerPrefs.SetFloat("Y", playerMovement.transform.position.y);
        PlayerPrefs.SetInt("Scene", SceneManager.GetActiveScene().buildIndex);
    }

    public void CancelButton() {
        playerMovement.pState = PlayerState.walk;
        saveButton.SetActive(false);
        cancelButton.SetActive(false);
        quitButton.SetActive(false);
        background.SetActive(false);
    }

    public void QuitButton() {
        PlayerPrefs.SetFloat("X", playerMovement.transform.position.x);
        PlayerPrefs.SetFloat("Y", playerMovement.transform.position.y);
        PlayerPrefs.SetInt("Scene", SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Quit");
        Application.Quit();
    }
}
