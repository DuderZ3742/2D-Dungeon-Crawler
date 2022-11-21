using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserInterface : MonoBehaviour
{
    public void ReloadScene()
    {
        SceneManager.LoadScene("MainGame");     //When the Reload Scene button is pressed in game, another random level will load
    }
}
