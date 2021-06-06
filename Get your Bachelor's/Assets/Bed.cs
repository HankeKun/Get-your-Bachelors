﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{
    private bool playerInRange;
    public GameObject keyEnter;
    public PlayerMovement playerMovement;
    public Animator animationGoSleep;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest5) {
                if (keyEnter.activeInHierarchy) {
                    PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQuestState.Quest6);
                    StartCoroutine(SleepCoroutine());
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest5) {
                keyEnter.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            keyEnter.SetActive(false);
        }
    }

    IEnumerator SleepCoroutine()
    {
        keyEnter.SetActive(false);
        playerMovement.pState = PlayerState.interact;
        animationGoSleep.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        animationGoSleep.SetTrigger("WakeUp");
        yield return new WaitForSeconds(1);
        playerMovement.pState = PlayerState.walk;
    }
}