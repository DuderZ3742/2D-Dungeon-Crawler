using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log ("Player Detected");      //If the player is detected, then nothing happends
        }
        else
        {
            Destroy(other.gameObject);      //If any other game object is detected, it gets destroyed  
            Debug.Log ("Game Object has been Destroyed");
        }
    }
}
