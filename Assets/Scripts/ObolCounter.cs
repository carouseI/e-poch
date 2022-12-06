using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ObolCounter : MonoBehaviour
{
    [SerializeField]
    List<NPC> _npcs; //npc list

    public int obolCount;

    private TextMeshProUGUI obolText;
    private int obolTotal;

    void Start()
    {
        obolText = GetComponent<TextMeshProUGUI>(); //get tmp comp
        obolTotal = 0; //set inventory start count
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("obols " + obolCount);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "NPC")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("key pressed");
                Destroy(GameObject.FindWithTag("NPC"), 1);
                obolCount++;
            }
        }
    }

    public void UpdateObolText(PlayerInventory playerInventory) //use inventory as parameter
    {
        obolText.text = playerInventory.ObolCount.ToString(); //set to inventory count
        obolTotal++; //increment

        //if (obolTotal >= maxCollectibles) //if max is reached
        //{
        //    SceneManager.LoadScene("End Menu"); //go to scene
        //}
    }
}
