using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserInterface : MonoBehaviour
{
    public GameObject miniMap;

    public GameObject miniMapCam;

    public void ReloadScene()
    {
        SceneManager.LoadScene("MainGame");     //When the Reload Scene button is pressed in game, another random level will load
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            miniMap.SetActive(true);
            miniMapCam.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            miniMap.SetActive(false);
            miniMapCam.SetActive(false);
        }
    }
}
