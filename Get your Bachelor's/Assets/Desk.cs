using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour
{
    public GameObject dialogBox;
    private bool playerInRange;
    public GameObject keyEnter;
    public PlayerMovement playerMovement;
    public GameObject textNoLetter;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (PlayerPrefs.GetInt("QuestState", 0) >= (int) Player.PlayerQestState.Quest2) {
                if (dialogBox.activeInHierarchy)
                {
                    dialogBox.SetActive(false);
                    keyEnter.SetActive(true);
                    playerMovement.pState = PlayerState.walk;
                }
                else
                {
                    dialogBox.SetActive(true);
                    keyEnter.SetActive(false);
                    playerMovement.pState = PlayerState.interact;
                    if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQestState.Quest2)
                        PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQestState.Quest3);
                }
            } else {
                StartCoroutine(GetLetterCoroutine(textNoLetter));
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            keyEnter.SetActive(true);
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

    IEnumerator GetLetterCoroutine(GameObject text)
    {
        text.SetActive(true);
        yield return new WaitForSeconds(2);
        text.SetActive(false);
    }
}
