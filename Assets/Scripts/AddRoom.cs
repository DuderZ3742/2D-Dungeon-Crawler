using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour
{
    private RoomTemplates templates;        //Access to the RoomTemplates Script

    public GameObject startDoors;

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        templates.rooms.Add(this.gameObject);

        Invoke("OpenDoors", 7.0f);
    }

    void OpenDoors()
    {
        Destroy(startDoors.gameObject);
        Debug.Log("Doors Are Open!");
    }
}
