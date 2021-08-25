using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProfLucky : MonoBehaviour
{
    public GameObject dialogBox;
    private bool playerInRange;
    public PlayerMovement playerMovement;
    public GameObject keyEnter;
    public TextMeshProUGUI text;
    public GameObject choiceBox;
    public DayNightValue dayNightValue;
    // Update is called once per frame
    void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E) && (playerMovement.pState != PlayerState.gamemenu))
        {
            if (dialogBox.activeInHierarchy)
            {
                FindObjectOfType<DialogManager>().DisplayNextSentence();
            }
            else
            {
                int questState = PlayerPrefs.GetInt("QuestState", 0);
                switch(questState) {
                    case int n when (n <= 7 && n >= 0):
                        FindObjectOfType<DialogManager>().StartDialogue(dialog1, dialogBox, keyEnter, text);
                        break;
                    case 8:
                        FindObjectOfType<DialogManager>().StartChoiceDialogue(dialog2, dialogBox, keyEnter, text, choiceBox);
                        break;
                    case int n when (n >= 9):
                        FindObjectOfType<DialogManager>().StartDialogue(dialog3, dialogBox, keyEnter, text);
                        break;
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
    
    private string[] dialog1 = { "Hey, momentan kann ich nichts für dich tun. Komm zu einem späteren Zeitpunkt wieder.", };

    private string[] dialog2 = { "Es ist Zeit für die Programmieren Prüfung.",
    "Bist du bereit?" };

    private string[] dialog3 = { "Glückwunsch du hast die Prüfung Programmieren bestanden.",
    "Nun heißt es dran bleiben und weiter machen." };

    private string[] dialog4 = { "Tut mir leid aber du hast die Prüfung nicht bestanden.",
    "Schau dir nochmal die Vorlesung an und komm wieder, wenn du bereit bist." };

    public GameObject exam;
    public GameObject examPage2;
    public void StartExam()
    {
        FindObjectOfType<DialogManager>().DisplayNextSentence();
        playerMovement.pState = PlayerState.interact;
        exam.SetActive(true);
    }

    public void EndExam()
    {
        exam.SetActive(false);
        examPage2.SetActive(false);

        // Exam bewerten lassen
        // if bestanden dialog 3 und setze QuestState+1
        if (FindObjectOfType<ExamPROG>().IsExamPassed()) {
            FindObjectOfType<DialogManager>().StartDialogue(dialog3, dialogBox, keyEnter, text);
            PlayerPrefs.SetInt("QuestState", (int) Player.PlayerQuestState.Quest9);
            dayNightValue.intensity = 0.5f;
        }
        else {
            FindObjectOfType<DialogManager>().StartDialogue(dialog4, dialogBox, keyEnter, text);
        }
        
        dialogBox.SetActive(true);
        keyEnter.SetActive(false);
        playerMovement.pState = PlayerState.interact;
    }

}
