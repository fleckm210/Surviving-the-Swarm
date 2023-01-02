using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //getting variables for basic movement
    public Rigidbody rb;
    public Transform tf;
    float movement = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //uses arrow keys input for movement
    void Update()
    {
        //gets input from arrow keys
        if (Input.GetKey(KeyCode.A))
        {
            //moves non-kenematic object in specified direction
            rb.MovePosition(new Vector3(tf.position.x - movement, tf.position.y, tf.position.z));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(new Vector3(tf.position.x + movement, tf.position.y, tf.position.z));
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(new Vector3(tf.position.x, tf.position.y, tf.position.z + movement));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.MovePosition(new Vector3(tf.position.x, tf.position.y, tf.position.z - movement));
        }
    }
}
