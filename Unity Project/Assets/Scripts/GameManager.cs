using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int milk;
    public static int multiplier;

    //Sets the amount of milk that the player has at the beginning of the game to '0' and the increment for
    //how much milk is added to '1'
    void Start()
    {
        multiplier = 1;
        milk = 0;
    }

}
