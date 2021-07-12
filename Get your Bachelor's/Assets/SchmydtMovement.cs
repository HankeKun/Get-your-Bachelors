using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SchmydtState
{
    walk,
    interact
}
public class SchmydtMovement : MonoBehaviour
{
    
    public float moveSpeed = 1f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    public SchmydtState sState;
    public Vector2 startingPosition = new Vector2(0, 4);
    public GameObject bubbleStepLeft;
    public GameObject bubbleStepRight;

    void Start()
    {
        movement.x = -1;
        sState = SchmydtState.walk;
        transform.position = startingPosition;
    }
    // Update is called once per frame
    void Update()
    {
        if (sState == SchmydtState.walk)
        {
            if (transform.position.x < -2) {
                movement.x = 1;
                StartCoroutine(GetLetterCoroutine(bubbleStepLeft));
            } 
            else if (transform.position.x > 2) {
                movement.x = -1;
                StartCoroutine(GetLetterCoroutine(bubbleStepRight));
            }
            
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        } 
        else 
        {
            animator.SetFloat("Speed", 0f);
        }
    }

    void FixedUpdate()
    {
        if (sState == SchmydtState.walk)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }

    IEnumerator GetLetterCoroutine(GameObject bubble)
    {
        bubble.SetActive(true);
        yield return new WaitForSeconds(2);
        bubble.SetActive(false);
    }
}
