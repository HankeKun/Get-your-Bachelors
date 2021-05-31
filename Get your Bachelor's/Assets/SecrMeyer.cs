using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SecrMeyer : MonoBehaviour
{
    private bool playerInRange;
    public GameObject keyEnter;
    public GameObject dialogBox;
    public PlayerMovement playerMovement;
    public TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if(dialogBox.activeInHierarchy)
            {
                FindObjectOfType<DialogManager>().DisplayNextSentence();
            }
            else
            {
                if(PlayerPrefs.GetInt("QuestState", 0) == (int) Player.PlayerQuestState.Quest3)
                {
                    FindObjectOfType<DialogManager>().StartDialogue(dialog1, dialogBox, keyEnter, text);
                    PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQuestState.Quest4);
                } 
                else if(PlayerPrefs.GetInt("QuestState", 0) < (int) Player.PlayerQuestState.Quest3)
                {
                    FindObjectOfType<DialogManager>().StartDialogue(dialog2, dialogBox, keyEnter, text);
                } 
                else
                {
                    FindObjectOfType<DialogManager>().StartDialogue(dialog3, dialogBox, keyEnter, text);
                }
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

    private string[] dialog1 = { "Hallo, du bist hier um deinen Studentenausweis zu holen, richtig? Hier ist er.",
    "Deine Matrikelnummer ist die 202174. Viel Spaß beim studieren!",
    "Informiere dich bei Sekretärin Müller was du nun tun solltest." };

    private string[] dialog2 = { "Hallo, ich glaube nicht das ich dir momentan behilflich sein kann. Komm zu einem späteren Zeitpunkt wieder" };

    private string[] dialog3 = { "Hallo, informier dich bei Sekretärin Müller, was es zu tun gibt." };
}
