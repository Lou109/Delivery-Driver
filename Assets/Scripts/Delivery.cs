using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery: MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;

    private void Start()
    {
        Debug.Log(hasPackage);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch! that really hurt you know");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Picked up package");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;        
        }     
    }
}
