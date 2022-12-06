using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    private Text obolText;

    private int obolTotal;

    [SerializeField]
    private int maxCollectibles;

    // Start is called before the first frame update
    void Start()
    {
        obolText = GetComponent<Text>(); //get text comp
        obolTotal = 0; //set inventory start count
    }

    public void UpdateObolText(PlayerInventory playerInventory) //use playerInvetory as parameter
    {
        obolText.text = playerInventory.ObolCount.ToString(); //set to inventory count
        obolTotal++; //increment

        if (obolTotal >= maxCollectibles) //if max is reached
        {
            SceneManager.LoadScene("End Menu"); //go to scene
        }
    }
}
