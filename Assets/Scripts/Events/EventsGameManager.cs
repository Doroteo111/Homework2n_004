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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            OnEnterKeyPressed();
        }

        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnEscapeKeyPressed();
        }*/
    }

    //OnEnterKeyPressed the corresponding functions so that
    //The enemy stops
    //The player changes its color to green
    //The text shows the player's distance to the enemy at that moment
    //The particle system starts playing

    

    //OnEscapeKeyPressed the corresponding functions so that
    //The enemy moves again
    //The player changes its color to its original color
    //The text shows the default message
    //The particle system stops playing

}
