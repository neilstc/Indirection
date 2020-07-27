using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{


    private float moveSpeed;
    public Rigidbody2D myRigidBody;

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
        myRigidBody = GetComponent<Rigidbody2D>();
        responPosition = transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {

        Movement();
      

    }

    private void Movement() {
        // player Movmement;

        
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            myRigidBody.velocity = new Vector3(moveSpeed, myRigidBody.velocity.y, 0f);
            transform.localScale = new Vector3(1f, 1f, 1f);

        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            myRigidBody.velocity = new Vector3(-moveSpeed, myRigidBody.velocity.y, 0f);
            transform.localScale = new Vector3(-1f, 1f, 1f);

        }
        else
        {
            myRigidBody.velocity = new Vector3(0f, myRigidBody.velocity.y, 0f);
        }

        if (Input.GetAxisRaw("Vertical") > 0f)
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, moveSpeed, 0f);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (Input.GetAxisRaw("Vertical") < 0f)
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, -moveSpeed, 0f);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, 0f, 0f);
            transform.localScale = new Vector3 (1f, 1f, 0f);
        }

    }
}
