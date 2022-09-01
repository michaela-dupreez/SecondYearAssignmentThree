using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInstructionsScript : MonoBehaviour
{
    public void LoadMenuInstructions()
    {
        SceneManager.LoadScene("MenuInstructionsScene");
    }
    //Opens the "MenuInstructionsScene" when the button linked to the LoadMenuInstructions function is clicked 
}
