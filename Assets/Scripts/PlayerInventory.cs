using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int ObolCount { get; private set; } //can be read by other scripts, can only be set in this one

    public UnityEvent<PlayerInventory> OnObolCollected; //set event, will take argument of type playerInventory

    public void ObolsCollected()
    {
        ObolCount++; //increment
        OnObolCollected.Invoke(this); //invoke event, pass through playerInventory to subcribers
    }
}