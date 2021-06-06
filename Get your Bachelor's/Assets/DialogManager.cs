using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    private Queue<string> sentences;

    public PlayerMovement playerMovement;
    private GameObject dialogBox;
    private GameObject keyEnter;
    private TextMeshProUGUI text;
    private bool isChoice;
    private GameObject choiceBox;
    
    void Start() {
        sentences = new Queue<string>();
    }

    public void StartDialogue(string[] dialogue, GameObject dialogBox, GameObject keyEnter, TextMeshProUGUI text)
    {
        this.dialogBox = dialogBox;
        this.keyEnter = keyEnter;
        this.text = text;
        this.isChoice = false;

        sentences.Clear();

        foreach (string sentence in dialogue) {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        if (sentences.Count == 0) {
            EndDialogue();
            return;
        }
        if (isChoice && sentences.Count == 1) {
            choiceBox.SetActive(true);
        }
        text.SetText(sentences.Dequeue());
    }

    void EndDialogue() {
        dialogBox.SetActive(false);
        keyEnter.SetActive(true);
        playerMovement.pState = PlayerState.walk;
    }

    public void StartChoiceDialogue(string[] dialogue,
                                    GameObject dialogBox,
                                    GameObject keyEnter,
                                    TextMeshProUGUI text,
                                    GameObject choiceBox)
    {
        this.dialogBox = dialogBox;
        this.keyEnter = keyEnter;
        this.text = text;
        this.isChoice = true;
        this.choiceBox = choiceBox;

        sentences.Clear();

        foreach (string sentence in dialogue) {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
}
