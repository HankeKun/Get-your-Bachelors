using System.Collections;
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
        if(playerInRange && Input.GetKeyDown(KeyCode.E) && (playerMovement.pState != PlayerState.gamemenu))
        {
            if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest5) {
                if (keyEnter.activeInHierarchy) {
                    PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQuestState.Quest6);
                    PlayerPrefs.SetFloat("DayNight", 1f);
                    StartCoroutine(SleepCoroutine());
                }
            } 
            else if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest7) {
                if (keyEnter.activeInHierarchy) {
                    PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQuestState.Quest8);
                    PlayerPrefs.SetFloat("DayNight", 1f);
                    StartCoroutine(SleepCoroutine());
                }
            }
            else if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest9) {
                if (keyEnter.activeInHierarchy) {
                    PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQuestState.Quest10);
                    PlayerPrefs.SetFloat("DayNight", 1f);
                    StartCoroutine(SleepCoroutine());
                }
            }
            else if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest11) {
                if (keyEnter.activeInHierarchy) {
                    PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQuestState.Quest12);
                    PlayerPrefs.SetFloat("DayNight", 1f);
                    StartCoroutine(SleepCoroutine());
                }
            }
            else if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest13) {
                if (keyEnter.activeInHierarchy) {
                    PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQuestState.Quest14);
                    PlayerPrefs.SetFloat("DayNight", 1f);
                    StartCoroutine(SleepCoroutine());
                }
            }
            else if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest15) {
                if (keyEnter.activeInHierarchy) {
                    PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQuestState.Quest16);
                    PlayerPrefs.SetFloat("DayNight", 1f);
                    StartCoroutine(SleepCoroutine());
                }
            }
            else if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest17) {
                if (keyEnter.activeInHierarchy) {
                    PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQuestState.Quest18);
                    PlayerPrefs.SetFloat("DayNight", 1f);
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
            if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest5 ||
                PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest7 ||
                PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest9 ||
                PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest11 ||
                PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest13 ||
                PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest15 ||
                PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest17) {
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
