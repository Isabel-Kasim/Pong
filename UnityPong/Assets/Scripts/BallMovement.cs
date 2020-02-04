using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public Object ball;
    public float ballSpeed = 20f;
    Rigidbody rb;
    private Vector2 direction;
    [SerializeField] [Range(0, 1000)] private float amplify = 1;
    public ForceMode forceMode;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        Invoke("movement", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void movement()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb.AddForce(new Vector2(Random.Range(0,20), Random.Range(-20,-5)));
        }
        else
        {
            rb.AddForce(new Vector2(Random.Range(-20,0), Random.Range(-15,-10)));
        }
    }
}
