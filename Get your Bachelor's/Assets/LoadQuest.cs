using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadQuest : MonoBehaviour
{
    public Player player;
    public GameObject[] quests;

    void Update()
    {
        int questState = (int) player.playerQuestState;
        for (int i=0; i < quests.Length; i++)
            if (i != questState) quests[i].SetActive(false);
        quests[questState].SetActive(true);
    }
}
