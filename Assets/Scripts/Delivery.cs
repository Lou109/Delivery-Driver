using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery: MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch! that really hurt you know");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("Picked up package");
        }
        if (other.tag == "Customer")
        {
            Debug.Log("Package delivered");
        }
        
    }
}
