using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfWolle : MonoBehaviour
{
    //public GameObject dialogBox;
    private bool playerInRange;
    //public PlayerMovement playerMovement;
    public GameObject keyEnter;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E))
        {

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
