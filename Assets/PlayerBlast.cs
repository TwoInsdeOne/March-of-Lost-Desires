using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBlast : MonoBehaviour
{
    public GameObject blastUp;
    public GameObject blastDown;
    public GameObject blastLeft;
    public GameObject blastRight;
    public GameObject blastUpLeft;
    public GameObject blastDownLeft;
    public GameObject blastUpRight;
    public GameObject blastDownRight;

    public PlayerControls playerControls;
    public PlayerMovement playerMovement;
    public float interval;
    private float timer;
    public SpriteRenderer sr;
    public Animator ani;
    public Rigidbody2D rb;
    public float offSetMultiplier;
    public float log;
    // Start is called before the first frame update
    void Start()
    {
        playerControls = new PlayerControls();
        playerControls.Actions.Enable();
        playerControls.Actions.Blast.started += Blast;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
    }
    public void Blast(InputAction.CallbackContext callbackContext)
    {
        if(timer <= 0)
        {
            Vector2 direction = playerMovement.GetDirection();
            float speed = rb.velocity.magnitude* offSetMultiplier;
            log = speed;
            if(direction.x > 0)
            {
                if(direction.y > 0)
                {
                    InstantiateBlast(blastUpRight, new Vector2(1f, 1f).normalized*speed);
                }else if(direction.y < 0)
                {
                    InstantiateBlast(blastDownRight, new Vector2(1f, -1f).normalized * speed);
                } else
                {
                    InstantiateBlast(blastRight, new Vector2(1f, 0) * speed);
                }
            }else if(direction.x < 0)
            {
                if (direction.y > 0)
                {
                    InstantiateBlast(blastUpLeft, new Vector2(-1f, 1f).normalized * speed);
                } else if (direction.y < 0)
                {
                    InstantiateBlast(blastDownLeft, new Vector2(-1f, -1f).normalized * speed);
                } else
                {
                    InstantiateBlast(blastLeft, new Vector2(-1f, 0) * speed);
                }
            } else
            {
                if(direction.y > 0)
                {
                    InstantiateBlast(blastUp, new Vector2(0, 1f) * speed);
                } else if(direction.y < 0)
                {
                    InstantiateBlast(blastDown, new Vector2(0, -1f) * speed);
                } else
                {
                    if (sr.flipX)
                    {
                        InstantiateBlast(blastLeft, new Vector2(0, 0f));
                    } else
                    {
                        InstantiateBlast(blastRight, new Vector2(0, 0f));
                    }
                }
            }
            ani.SetInteger("move", 4);
            timer = interval;
        }
    }
    private void InstantiateBlast(GameObject b, Vector2 offset)
    {
        GameObject o = Instantiate(b);
        o.transform.SetParent(transform);
        o.transform.localPosition = Vector3.zero;
        //o.transform.position = transform.position;
        
        //o.transform.position = transform.position + new Vector3(offset.x, offset.y, 0);
        Destroy(o, 0.7f);
    }
}
