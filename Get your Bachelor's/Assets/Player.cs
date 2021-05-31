using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerQuestState playerQuestState;

    public void Update() {
        playerQuestState = (PlayerQuestState) PlayerPrefs.GetInt("QuestState", 0);
    }

    public enum PlayerQuestState {
        Nothing = 0,
        Quest1 = 1, // Du hast Post! Hole den Brief.
        Quest2 = 2, // Geh an deinen Schreibtisch und lese den Brief.
        Quest3 = 3, // Gehe zur TH und hole deinen Studentenausweis.
        Quest4 = 4 // 
    }
}
