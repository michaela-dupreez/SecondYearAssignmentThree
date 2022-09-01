using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ClickScript : MonoBehaviour
{
    public int itemCost;
    public float inflation;

    public Text milkAmountText;
    public Text inflationAmountText;

    //Increments the milk value every time it's clicked.
    public void Increment()
    {
        GameManager.milk += GameManager.multiplier;
    }

    //Sets the cost of the purchasable item and the rate of inflation for the start of the game.
    private void Start()
    {
        itemCost = 25;
        inflation = 5f;
    }

    //Function for buying the purchasable items.
    public void Buy(int ItemNum)
    //For purchasable item #1 (i.e. ItemNum == 1).
    {
        if (ItemNum == 1 && GameManager.milk >= itemCost)
        {
            GameManager.multiplier += 2;
            GameManager.milk -= itemCost;
            itemCost = itemCost + (int)(itemCost * inflation / 10);
        }
    }

    void Update()
    {
        //Changes the text for the number of milk buckets that the player has gained.
        milkAmountText.text = "Milk: " + GameManager.milk + " buckets of milk.";
        //Changes the text for the price of the purchasable item as it is inflated.
        inflationAmountText.text = "Cost: " + itemCost + " Milk Buckets.";
    }

}
