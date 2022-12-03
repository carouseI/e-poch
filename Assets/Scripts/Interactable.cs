using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if player is in range
        {
            collision.gameObject.GetComponent<BoatController>().isInDockingRange = true; //set range to true
            Debug.Log("player now in range");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player")) //if player is in range
        {
            collision.gameObject.GetComponent<BoatController>().isInDockingRange = false; //set range to false
            Debug.Log("player has now left range");

            BoatController temp = collision.gameObject.GetComponent<BoatController>();
            temp.nextDockIndex++; //get next dock in index
            temp.nextDock = temp._docks[temp.nextDockIndex].transform; //set transform in index
        }
    }
}
