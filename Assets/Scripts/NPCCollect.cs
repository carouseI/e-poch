using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class NPCCollect : MonoBehaviour
{
    [SerializeField]
    List<NPC> _npcs; //npc list

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "NPC")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("key pressed");
                Destroy(GameObject.FindWithTag("NPC"), 2);
            }
        }
    }

    #region
    //float raycastDistance = 3;

    ////public Text interactText; //create GUI canvas**

    //private void Update()
    //{
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //create ray @ main cam's centre point / center screen

    //    RaycastHit hit; //create hit used to callback hit object

    //    if(Physics.Raycast(ray, out hit, raycastDistance))
    //    {
    //        if (hit.collider.CompareTag("NPC"))
    //        {
    //            //interactText.text = "Press [E] to admit";

    //            if (Input.GetKeyDown(KeyCode.E))
    //            {
    //                Debug.Log("e was pressed while looking at npc");
    //                Destroy(gameObject, 3);
    //            }
    //        }
    //    }
    //    //else if(hit.collider)
    //}
    #endregion
}