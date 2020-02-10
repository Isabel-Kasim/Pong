using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Transform PaddleRight;
    public Transform PaddleLeft;
    [SerializeField] [Range(1, 100)] private float amplify = 5;
    private float rightVelocity = 0;
    private float leftVelocity = 0;
    
    
    

    // Update is called once per frame
    void Update()
    {
        rightVelocity = Input.GetAxis("PaddleRight");
        leftVelocity = Input.GetAxis("PaddleLeft");
    }

    private void FixedUpdate()
    {
        

        //Movement(new Vector3(0, 0, leftVelocity), PaddleLeft);
    }

    void Movement(Vector3 direction, Transform paddle)
    {
        paddle.transform.position = direction;
    }
}
