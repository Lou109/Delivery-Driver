using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch! that really hurt you know");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hey! that's a hit and run come back!");
    }
}
