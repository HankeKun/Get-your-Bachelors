using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadQuest : MonoBehaviour
{
    public Player player;
    public GameObject[] quests;

    void Update()
    {
        switch (player.playerQuestState) {
            case Player.PlayerQuestState.Nothing:
                for (int i=0; i < quests.Length; i++)
                    if (i != 0) quests[i].SetActive(false);
                quests[0].SetActive(true);
                break;
            case Player.PlayerQuestState.Quest1:
                for (int i=0; i < quests.Length; i++)
                    if (i != 1) quests[i].SetActive(false);
                quests[1].SetActive(true);
                break;
            case Player.PlayerQuestState.Quest2:
                for (int i=0; i < quests.Length; i++)
                    if (i != 2) quests[i].SetActive(false);
                quests[2].SetActive(true);
                break;
            case Player.PlayerQuestState.Quest3:
                for (int i=0; i < quests.Length; i++)
                    if (i != 3) quests[i].SetActive(false);
                quests[3].SetActive(true);
                break;
            case Player.PlayerQuestState.Quest4:
                for (int i=0; i < quests.Length; i++)
                    if (i != 4) quests[i].SetActive(false);
                quests[4].SetActive(true);
                break;
            default:
                break;
        }
    }
}
