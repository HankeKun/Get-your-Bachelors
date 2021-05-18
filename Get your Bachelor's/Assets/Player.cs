using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerQestState playerQestState;

    public void Update() {
        playerQestState = (PlayerQestState) PlayerPrefs.GetInt("QuestState", 0);
    }

    public enum PlayerQestState {
        Nothing = 0,
        Quest1 = 1,
        Quest2 = 2,
        Quest3 = 3,
        Quest4 = 4
    }
}
