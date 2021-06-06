using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProfKarl : MonoBehaviour
{
    public GameObject dialogBox;
    private bool playerInRange;
    public PlayerMovement playerMovement;
    public GameObject keyEnter;
    public TextMeshProUGUI text;
    public GameObject choiceBox;

    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (dialogBox.activeInHierarchy)
            {
                FindObjectOfType<DialogManager>().DisplayNextSentence();
            }
            else
            {
                int questState = PlayerPrefs.GetInt("QuestState", 0);
                switch(questState) {
                    case int n when (n <= 5 && n >= 0):
                        FindObjectOfType<DialogManager>().StartDialogue(dialog1, dialogBox, keyEnter, text);
                        break;
                    case 6:
                        FindObjectOfType<DialogManager>().StartChoiceDialogue(dialog2, dialogBox, keyEnter, text, choiceBox);
                        break;
                    case int n when (n >= 7):
                        FindObjectOfType<DialogManager>().StartDialogue(dialog3, dialogBox, keyEnter, text);
                        break;
                }
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
    
    private string[] dialog1 = { "Hey, momentan kann ich nichts für dich tun. Komm zu einem späteren Zeitpunkt wieder.", };

    private string[] dialog2 = { "Hör dir die Vorlesung an indem du dich an einen Tisch setzt.",
    "Bist du bereit für die Prüfung?" };

    private string[] dialog3 = { "Glüsckwunsch du hast die Prüfung Grundlagen der Informatik bestanden.",
    "Nun heißt es dran bleiben und weiter machen." };
}