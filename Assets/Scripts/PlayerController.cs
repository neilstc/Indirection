using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{


    private float moveSpeed;
    public Rigidbody2D rigidbody2D;

    // bound stuff
    public Transform boundCheck;
    public float boundCheckRadius;
    public LayerMask whatIsBound;
    public bool boundHit;

    public Vector3 responPosition;



    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10;
        rigidbody2D = GetComponent<Rigidbody2D>();
        responPosition = transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {

        Movement();
        //// player Movmement;
        //if (Input.GetAxisRaw("Horizontal") > 0f)
        //{
        //    rigidbody2D.velocity = new Vector3(moveSpeed, rigidbody2D.velocity.y, 0f);
        //    transform.localScale = new Vector3(1f, 1f, 1f);

        //}
        //else if (Input.GetAxisRaw("Horizontal") < 0f)
        //{
        //    rigidbody2D.velocity = new Vector3(-moveSpeed, rigidbody2D.velocity.y, 0f);
        //    transform.localScale = new Vector3(-1f, 1f, 1f);

        //}
        //else {
        //    rigidbody2D.velocity = new Vector3(0f, rigidbody2D.velocity.y, 0f);
        //}
    }

    private void Movement() {
        // player Movmement;

        
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            rigidbody2D.velocity = new Vector3(moveSpeed, rigidbody2D.velocity.y, 0f);
            transform.localScale = new Vector3(1f, 1f, 1f);

        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            rigidbody2D.velocity = new Vector3(-moveSpeed, rigidbody2D.velocity.y, 0f);
            transform.localScale = new Vector3(-1f, 1f, 1f);

        }
        else
        {
            rigidbody2D.velocity = new Vector3(0f, rigidbody2D.velocity.y, 0f);
        }

        if (Input.GetAxisRaw("Vertical") > 0f)
        {
            rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.x, moveSpeed, 0f);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (Input.GetAxisRaw("Vertical") < 0f)
        {
            rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.x, -moveSpeed, 0f);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else {
            rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.x, 0f, 0f);
            transform.localScale = new Vector3 (1f, 1f, 1f);
        }

    }
}
