//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//[RequireComponent(typeof(BoatController))]

//public class Rotating : MonoBehaviour
//{
//    public float speed;
//    public float rotationSpeed;

//    // Update is called once per frame
//    void Update()
//    {
//        BoatController controller = GetComponent<BoatController>();


//        if (transform != null)
//        {
//            transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed, 0);
//            var forward = transform.TransformDirection(Vector3.forward);
//            float curSpeed = speed * Input.GetAxis("Vertical");
//            controller.SimpleMove(forward * curSpeed);
//        }
//    }
//}
