using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomKeySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateKey());      //Start timer on first frame
    }

    IEnumerator GenerateKey()
    {
        yield return new WaitForSeconds(5f);        //Starts deleting the keys after 5 seconds
        
        //Remove Keys
        GameObject[] floorFull;
        floorFull = GameObject.FindGameObjectsWithTag("Key");
        for(int i = 0; i < floorFull.Length; i++)
        {
            bool coinFlip = (Random.Range(0, 2) == 0);
            if(coinFlip == true)
            {
                Destroy(floorFull[i]);
            }
        }
        yield return new WaitForSeconds(5f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
