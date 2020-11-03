using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        if(isGrounded)
        rb.AddForce(new Vector3(0f, 15f, 0f),ForceMode.Impulse);
    }

    public void MoveLeft()
    {
        if (isGrounded)
        {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 15f);
        //rb.AddForce(new Vector3(0f, 0f, 500f));
        }

    }

    public void MoveRight()
    {
        if (isGrounded)
        {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -15f);
        //rb.AddForce(new Vector3(0f, 0f, -500f));
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
