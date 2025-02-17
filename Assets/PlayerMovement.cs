using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public PlayerControls playerControls;
    public Rigidbody2D rb;
    public Animator ani;
    public SpriteRenderer sr;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        playerControls = new PlayerControls();
        playerControls.Enable();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = playerControls.Movements.Move.ReadValue<Vector2>();
        rb.AddForce(direction*speed, ForceMode2D.Impulse);
        if(direction.x < 0)
        {
            sr.flipX = true;
        }else if(direction.x > 0)
        {
            sr.flipX = false;
        }
        if(direction.sqrMagnitude > 0)
        {
            ani.SetInteger("move", 1);
        } else
        {
            ani.SetInteger("move", 0);
        }
        if(direction.y > 0)
        {
            ani.SetInteger("move", 2);
        }else if(direction.y < 0)
        {
            ani.SetInteger("move", 3);
        }
    }
}
