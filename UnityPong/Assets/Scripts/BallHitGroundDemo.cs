using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHitGroundDemo : MonoBehaviour
{
    [SerializeField] private AudioClip bang;

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(bang);
    }
}
