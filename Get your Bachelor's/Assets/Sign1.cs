using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign1 : MonoBehaviour
{
    public GameObject dialogBox;
    private bool playerInRange;
    public PlayerMovement playerMovement;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if(dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
                playerMovement.pState = PlayerState.walk;
            }
            else
            {
                dialogBox.SetActive(true);
                playerMovement.pState = PlayerState.interact;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
