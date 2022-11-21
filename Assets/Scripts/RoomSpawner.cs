using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;

    private RoomTemplates templates;
    private int random;

    private bool spawned = false;

    public float waitTime = 4f;

    void Start()
    {
        Destroy(gameObject, waitTime);
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.08f);     //The speed at which the rooms will spawn
    }

    // Update is called once per frame
    void Spawn()
    {
        if(spawned == false)
        {
            if(openingDirection == 1)       //If theres a rooms with an open top door...
        {
            random = Random.Range(0, templates.bottomRooms.Length);
            Instantiate(templates.bottomRooms[random], transform.position, templates.bottomRooms[random].transform.rotation);       //It will spawn a room with a bottom door.
        }

        else if(openingDirection == 2)      //If theres a room with an open bottom door...
        {
            random = Random.Range(0, templates.topRooms.Length);
            Instantiate(templates.topRooms[random], transform.position, templates.topRooms[random].transform.rotation);     //It will spawn a room with a top door.
        }

        else if(openingDirection == 3)      //If theres a room with an open right door...
        {
            random = Random.Range(0, templates.leftRooms.Length);
            Instantiate(templates.leftRooms[random], transform.position, templates.leftRooms[random].transform.rotation);       //It will spawn a room with a left door.
        }

        else if(openingDirection == 4)      //If theres a room with an open left door...
        {
            random = Random.Range(0, templates.rightRooms.Length);
            Instantiate(templates.rightRooms[random], transform.position, templates.rightRooms[random].transform.rotation);     //It will spawn a room with a right door.
        }

        spawned = true;

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("SpawnPoint"))
        {
            if(other.GetComponent<RoomSpawner>().spawned == false && spawned == false)      //If theres an open door with no closed room...
            {
                Instantiate(templates.closedRoom, transform.position, Quaternion.identity);     //It will spawn a block so the player cannot escape the dungeon.
                Destroy(other.gameObject);
            }

            spawned = true;
        }
    
    }
}
