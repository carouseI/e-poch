using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange) //if in range
        {
            if (Input.GetKeyDown(interactKey)) //and player presses key
            {
                interactAction.Invoke(); //trigger event
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if player is in range
        {
            isInRange = true;
            Debug.Log("player now in range");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        isInRange = false;
        Debug.Log("player has now left range");
    }
}
