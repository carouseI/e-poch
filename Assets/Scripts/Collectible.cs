using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) //detect char + obj collision; call whenever smth collides with xtal
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>(); //check collision is with char, check for playerInventory comp

        if (playerInventory != null) //if not null
        {
            playerInventory.ObolsCollected(); //use playerInventory to call obols collected method
            gameObject.SetActive(false); //when collected, set to inactive
        }
    }
}
