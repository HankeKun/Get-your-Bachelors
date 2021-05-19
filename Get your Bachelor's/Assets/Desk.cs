using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour
{
    private bool playerInRange;
    public GameObject keyEnter;
    public PlayerMovement playerMovement;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQestState.Quest2) {
                Debug.Log("Read letter");
                //playerMovement.pState = PlayerState.interact;
            } else {
                Debug.Log("Nothing to do");
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
}
