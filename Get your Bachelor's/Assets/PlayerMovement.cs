using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    walk,
    interact,
    gamemenu
}
public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    public PlayerState pState;
    public VectorValue startingPosition;

    void Start()
    {
        pState = PlayerState.walk;
        transform.position = startingPosition.initialValue;
    }
    // Update is called once per frame
    void Update()
    {
        if (pState == PlayerState.walk)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            movement = movement.normalized;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveSpeed = 7.5f;
            }
            else
            {
                moveSpeed = 5f;
            }

            if (movement != Vector2.zero)
            {
                animator.SetFloat("Horizontal", movement.x);
                animator.SetFloat("Vertical", movement.y);
            }
            animator.SetFloat("Speed", movement.sqrMagnitude);
        } 
        else 
        {
            animator.SetFloat("Speed", 0f);
        }
    }

    void FixedUpdate()
    {
        if (pState == PlayerState.walk)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }

}
