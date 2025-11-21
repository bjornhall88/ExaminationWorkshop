using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private Animator Movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
        {
            Movement = GetComponent<Animator>();
            
            Movement.SetBool("Up", false);
            Movement.SetBool("Down", false);
            Movement.SetBool("Left", false);
            Movement.SetBool("Right", false);
        }
    
        // Update is called once per frame 
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Movement.SetBool("Up", true);
        }
        if (Input.GetKeyUp("w"))
        {
            Movement.SetBool("Up", false);
        }
        
        if (Input.GetKeyDown("s"))
        {
            Movement.SetBool("Down", true);
        }
        if (Input.GetKeyUp("s"))
        {
            Movement.SetBool("Down", false);
        }
            
        if (Input.GetKeyDown("d"))
        {
            Movement.SetBool("Right", true);
        }
        if (Input.GetKeyUp("d"))
        {
            Movement.SetBool("Right", false);
        }
            
        if (Input.GetKeyDown("a"))
        {
            Movement.SetBool("Left", true);
        }
        if (Input.GetKeyUp("a"))
        {
            Movement.SetBool("Left", false);
        }
    }
}
