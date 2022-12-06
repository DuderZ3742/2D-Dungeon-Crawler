using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour
{
    private RoomTemplates templates;        //Access to the RoomTemplates Script

    public GameObject startDoors;

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();            //Adds any room with the tag "Rooms" to templates game object
        templates.rooms.Add(this.gameObject);

        Invoke("OpenDoors", 7.0f);          //Starts a 7 seconds countdown on the first frame
    }

    void OpenDoors()
    {
        Destroy(startDoors.gameObject);         //Destroys the Doors game object, which also includes the black background as a child
        Debug.Log("Doors Are Open!");
    }
}
