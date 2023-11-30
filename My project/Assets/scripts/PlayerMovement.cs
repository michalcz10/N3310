using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private bool isAI;
    [SerializeField] private GameObject ball;

    private Rigidbody2D rb;
    private Vector2 playerMove;

    private bool isButtonHeld = false;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isAI)
        {
            AIControl();
        }
    }

    public void MoveUp()
    {
        if (!isAI && isButtonHeld) { playerMove = new Vector2(0, 1f); }
        else { playerMove = new Vector2(0, 0); }
    }
    public void MoveDown()
    {
        if (!isAI && isButtonHeld) { playerMove = new Vector2(0, -1f); }
        else { playerMove = new Vector2(0, 0); }
    }

    public void OnButtonDown()
    {
        isButtonHeld = true;
    }

    public void OnButtonUp()
    {
        isButtonHeld = false;
    }

    private void AIControl()
    {
        if(ball.transform.position.y > transform.position.y + 0.5f) 
        {
            playerMove = new Vector2(0, 1);
        }
        else if(ball.transform.position.y < transform.position.y - 0.5f)
        {
            playerMove= new Vector2(0, -1);
        }
        else
        {
            playerMove = new Vector2(0, 0);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = playerMove * movementSpeed;
    }
}
