using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerQestState playerQestState = PlayerQestState.Quest1;

    public enum PlayerQestState {
        Quest1,
        Quest2,
        Quest3,
        Quest4
    }
}
