using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign1 : MonoBehaviour
{
    public GameObject dialogBox;
    private bool playerInRange;
    public PlayerMovement playerMovement;
    public Animator animator;
    public GameObject keyEnter;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E) && (playerMovement.pState != PlayerState.gamemenu))
        {
            if(dialogBox.activeInHierarchy)
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
