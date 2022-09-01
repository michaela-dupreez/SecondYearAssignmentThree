using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
    //Opens the "StartScene" when the button linked to the LoadStartMenu function is clicked 
}
