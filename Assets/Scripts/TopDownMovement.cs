using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;
    private Vector2 moveInput;

    public Text collectableText;

    public int collectables;

    // Start is called before the first frame update
    void Start()
    {
        collectables = 0;
    }

    // Update is called once per frame
    void Update()
    {
        collectableText.text = collectables + " / 7";

        if(collectables >= 8)       //If the collectable counter goes over 7, it will still = 7 because thats all the player needs
        {
            collectables = 7;
            Debug.Log("You Already Have 7 Orbs");
        }

        moveInput.x = Input.GetAxisRaw("Horizontal");       //New input system, A and D controls the x axis movements for the player
        moveInput.y = Input.GetAxisRaw("Vertical");         //W and S controls the y axis movements for the player

        moveInput.Normalize();

        rb2d.velocity = moveInput * moveSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Key"))         //If the player walks into an object tagged Key...
        {
            collectables = collectables + 1;        //+1 is added onto the collectable counter...
            Destroy(other.gameObject);          //the collectable thats just been picked up will be detroyed
        }

        if(other.CompareTag("End"))         //If the player walks into an object tagged End...
        {
            if(collectables >= 7)       //If the player has collected 7 or more collectables...
            {
                SceneManager.LoadScene("MainGame");     //Another random level will load
            }
            else{
                Debug.Log("Cannot Exit, You Do Not Have 7 Orbs!");      //If the player hasn't collected 7 collectables when they walked through the object tagged End, Nothing will happen
            }
        }
    
    }
}
