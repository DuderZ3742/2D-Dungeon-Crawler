using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] bottomRooms;        //Arrays for the different types of rooms
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject closedRoom;

    public List<GameObject> rooms;      //All of the spawned rooms get put into a list so it knows which room spawned last

    public float waitTime;      //Timer
    private bool spawnedExit;
    public GameObject end;

    void Update()
    {
        if(waitTime <= 0 && spawnedExit == false)
        {
            for(int i = 0; i <rooms.Count; i++)
            {
                if(i == rooms.Count-1)
                {
                    Instantiate(end, rooms[i].transform.position, Quaternion.identity);        //After the last room has spawned, the exit will spawn
                    spawnedExit = true;
                    
                    Invoke("SpawnCollectables", 3.0f);          //Activates the SpawnCollectables function after 3 seconds
                }
            }
            }

            else{
                waitTime -= Time.deltaTime;
            }
        }
        void SpawnCollectables()
        {
            //Remove Keys
        GameObject[] orbsList;
        orbsList = GameObject.FindGameObjectsWithTag("Key");            //Adds any object with the tag "Key" to the orbsList Array
        for(int i = 0; i < orbsList.Length; i++)
        {
            bool coinFlip = (Random.Range(0, 2) == 0);              //Coin flip, if true the game object gets deleted...
            if(coinFlip == true)                                    //This happends for all game objects within the orbsList Array
            {
                Destroy(orbsList[i]);
            }
        }
        }
    }
