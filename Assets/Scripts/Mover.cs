using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Change value in editor 
    [SerializeField] float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();        
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the nhk, jk welcome to the game ;)");
        Debug.Log("Let us start by using wasd or the arrow keys to move the player");
        Debug.Log("Do not hit the walls!");
    }
    
    void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }
}
