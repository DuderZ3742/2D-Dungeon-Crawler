using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOrbSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(GenerateOrb());      //Start timer on first frame
    }

    IEnumerator GenerateOrb()
    {
        yield return new WaitForSeconds(5f);        //Starts deleting the keys after 5 seconds
        
        //Remove Keys
        GameObject[] orbsList;              //Adds any game object with the tag "Key" to the orbsList array automatically
        orbsList = GameObject.FindGameObjectsWithTag("Key");
        for(int i = 0; i < orbsList.Length; i++)
        {
            bool coinFlip = (Random.Range(0, 2) == 0);          //Coin flip
            if(coinFlip == true)
            {
                Destroy(orbsList[i]);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
