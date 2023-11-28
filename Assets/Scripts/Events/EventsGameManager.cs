using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class EventsGameManager : MonoBehaviour
{
    // DECLARE EVENT

    //ENTER
    public delegate void EnterKeyPressed();
    public static event EnterKeyPressed OnEnterKeyPressed;

    //ESCAPE
    public delegate void OnEscapeKey();
    public static event OnEscapeKey OnEscapeKeyPressed;

    private void Update() //calculate when the input is press
    {
        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            if(OnEnterKeyPressed != null)
            {
                OnEnterKeyPressed();
            }
           
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (OnEnterKeyPressed != null)
            {
                OnEscapeKeyPressed();
            }
        }
    }

    //OnEnterKeyPressed the corresponding functions so that
    
    //The text shows the player's distance to the enemy at that moment
   

    

    //OnEscapeKeyPressed the corresponding functions so that
    
    //The text shows the default message
    

}
