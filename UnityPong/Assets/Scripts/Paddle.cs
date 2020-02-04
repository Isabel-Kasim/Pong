using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] [Range(0, 1000)] private float amplify = 1;
    public ForceMode forceMode;
    private Vector2 movement;
    private Rigidbody rpaddle;
    private Vector3 input;
    public float boundY = 2.25f;

    public float speed = 100.0f;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        if (collision.gameObject.tag == "Ball")
        {
            Vector3 launchAngle = new Vector3(1, 1, 0) * amplify;
            rb.AddForce(launchAngle, forceMode);
        }

    }

   

    // Start is called before the first frame update
    void Start()
    {
        rpaddle = GetComponent<Rigidbody>();
        //input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rpaddle.velocity;
        if (Input.GetKey(KeyCode.P))
        {
            vel.z = speed;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            vel.z = -speed;
        }
        else
        {
            vel.z = 0;
        }

        var pos = transform.position;
        if (pos.z > boundY)
        {
            pos.z = boundY;
        }
        else if (pos.z < -boundY)
        {
            pos.z = -boundY;
        }
        transform.position = pos;
    }
}
