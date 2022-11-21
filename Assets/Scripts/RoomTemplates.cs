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
                }
            }
            }

            else{
                waitTime -= Time.deltaTime;
            }
        }
    }
