using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButtonScript : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
    //Exits the game when the button linked to the ExitGame function is clicked 
}
