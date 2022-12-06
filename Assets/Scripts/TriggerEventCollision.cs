//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Events;

//public class TriggerEventCollision : MonoBehaviour
//{
//    public UnityEvent unityEvent; //event
//    private Transform teleportTarget;
//    private GameObject prefab; //object that will triger event
    
//    private void OnTriggerEnter(Collider collision)
//    {
//        if (collision.gameObject.CompareTag("Player")) //if player is in range
//        {
//            collision.gameObject.GetComponent<BoatController>().isInDockingRange = true; //set range to true
//            Debug.Log("player now in range");

//            //unityEvent.Invoke();
//            //prefab.transform.position = teleportTarget.transform.position;

//            //Invoke("CollectNPC", 3);
//            //Invoke("Teleport", 3);
//        }
//    }

//    //private void Start()
//    //{
//    //    Invoke("Teleport", 3.0f);
//    //}

//    //private void Teleport()
//    //{
//    //    prefab.transform.position = teleportTarget.transform.position;
//    //}

//    //private void Update()
//    //{
//    //    //prefab.transform.position = new Vector3(6.34f, 0, 0);
//    //    prefab.transform.position = teleportTarget.transform.position;
//    //}

//    //private void CollectNPC()
//    //{
//    //BoatController temp = gameObject.GetComponent<BoatController>();
//    //temp.nextDockIndex++; //get next dock in index
//    //temp.nextDock = temp._docks[temp.nextDockIndex].transform; //set transform in index

//    //prefab.transform.position = new Vector3(temp._docks[temp.nextDockIndex].transform, 0, 0);
//    //prefab.transform.position = teleportTarget.transform.position;

//    //    prefab.transform.position = teleportTarget.transform.position;
//    //}

//    //private void OnTriggerExit(Collider collision)
//    //{
//    //    if(collision.gameObject.CompareTag("Player")) //if player is not in range
//    //    {
//    //        collision.gameObject.GetComponent<BoatController>().isInDockingRange = false; //set range to false
//    //        Debug.Log("player has now left range");

//    //        BoatController temp = collision.gameObject.GetComponent<BoatController>();
//    //        temp.nextDockIndex++; //get next dock in index
//    //        temp.nextDock = temp._docks[temp.nextDockIndex].transform; //set transform in index

//    //        //Physics.SyncTransforms();
//    //    }
//    //}

//    private void OnTriggerExit(Collider collision)
//    {
//        if (collision.gameObject.CompareTag("NPC")) //if player is not in range
//        {
//            collision.gameObject.GetComponent<Teleport>().enabled = true; //set range to false
//            Debug.Log("player has now left range");

//            BoatController temp = collision.gameObject.GetComponent<BoatController>();
//            temp.nextDockIndex++; //get next dock in index
//            temp.nextDock = temp._docks[temp.nextDockIndex].transform; //set transform in index

//            //Physics.SyncTransforms();
//        }
//    }
//}
