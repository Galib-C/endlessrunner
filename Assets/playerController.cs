using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatIsGround;

    public float jumpForce = 100.0f;


    private float maxSpeed = 5.0f;
    bool isOnGround = false;

    //create a reference to the rigidbody2D so we can manipulate it
    Rigidbody2D playerObject;

    // Start is called before the first frame update
    void Start()
    {
        //find the rigidbody 2D component that is attached to the same object as this script
        playerObject =  GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed = 10.0f;
        }else
        {
            maxSpeed = 5.0f;
        }
            

        //Create a 'float' that will be equal to the players horizontal input
        //float movementValueX = Input.GetAxis("Horizontal");

        float movementValueX = 1.0f;

        //change the x velocity of the rigidbody2D to be equal to the movement value
        playerObject.velocity = new Vector2 (movementValueX * maxSpeed, playerObject.velocity.y);

        //check to see if the ground check object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f, jumpForce));
        }

    }
}