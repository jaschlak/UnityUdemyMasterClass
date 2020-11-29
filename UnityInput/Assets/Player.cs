using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 3.5f;
    public float rotatingSpeed = 40f;
    public float jumpingForce = 300;
    private bool canJump = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move right
        if (Input.GetKey("right") | Input.GetKey("d"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        // move left
        if (Input.GetKey("left") | Input.GetKey("a"))
        {
            transform.position += -transform.right * speed * Time.deltaTime;
        }

        // move forwards
        if (Input.GetKey("up") | Input.GetKey("w"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        // move backwards
        if (Input.GetKey("down") | Input.GetKey("s"))
        {
            transform.position += -transform.forward * speed * Time.deltaTime;
        }

        // rotate left
        if (Input.GetKey("q"))
        {
            transform.RotateAround(transform.position, Vector3.up, -rotatingSpeed * Time.deltaTime);
        }

        // rotate right
        if (Input.GetKey("e"))
        {
            transform.RotateAround(transform.position, Vector3.up, rotatingSpeed * Time.deltaTime);
        }

        // jump
        if (Input.GetKeyDown("space") && canJump)
        {
            GetComponent<Rigidbody>().AddForce(0, jumpingForce, 0);
            canJump = false;
        }

        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Floor")
        {
            Debug.Log("Hit the floor");
        }

        canJump = true;


    }
}
