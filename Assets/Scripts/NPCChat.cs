using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCChat : MonoBehaviour
{
    [SerializeField]
    public GameObject chatBubblePrefab; 

    void Start()
    {
        chatBubblePrefab.SetActive(false); //set default to off
    }

    void OnTriggerEnter(Collider collision) //enter collider
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            chatBubblePrefab.SetActive(true); //turn on
        }
    }

    void OnTriggerExit(Collider collision) //exit collider
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            chatBubblePrefab.SetActive(false); //turn off
        }
    }
}