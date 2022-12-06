using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    #region wasd
    //[SerializeField] float speed;
    //[SerializeField] float rotationSpeed;

    //public Vector3 currentPosition;

    //// Update is called once per frame
    //void Update()
    //{
    //    Movement();

    //    //BoatController controller = GetComponent<BoatController>();

    //    //if (transform != null)
    //    //{
    //    //    transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed, 0);
    //    //    var forward = transform.TransformDirection(Vector3.forward);
    //    //    float curSpeed = speed * Input.GetAxis("Vertical");
    //    //    controller.move(forward * curSpeed);
    //    //}
    //}

    //public void Movement()
    //{
    //    if (Input.GetKey(KeyCode.Z)) currentPosition.z += speed * Time.deltaTime; //w, forward
    //    //if (Input.GetKey(KeyCode.S)) currentPosition.z -= speed * Time.deltaTime; //s, back
    //    if (Input.GetKey(KeyCode.D)) currentPosition.x += speed * Time.deltaTime; //d, right
    //    if (Input.GetKey(KeyCode.Q)) currentPosition.x -= speed * Time.deltaTime; //a, left

    //    //if input.GetAxis horizontal, rigidbody.addForce(Vector3 right * G

    //    transform.position = currentPosition;
    //    //Quaternion rotation = Quaternion.LookRotation(currentPosition, Vector3.up);
    //}
    #endregion

    #region wasd rotation n°01 - ipr
    //public void Rotation()
    //{
    //    Vector3 targetDirection = Vector3.zero;

    //    targetDirection.Normalize();
    //    targetDirection.y = 0;

    //    if (targetDirection == Vector3.zero)
    //        targetDirection = transform.forward;

    //    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
    //    Quaternion playerRotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

    //    transform.rotation = playerRotation;
    //}
    #endregion

    #region auto-move
    [SerializeField] float moveSpeed = 1f;
    //public static int moveSpeed = 1f;
    public Vector3 boatDirection = Vector3.forward;

    public void Update()
    {
        transform.Translate(boatDirection * moveSpeed * Time.deltaTime);
    }
    #endregion

    #region node-based movement w/ docking
    //[SerializeField]
    //protected float _connectivityRadius = 50f; //connection radius

    //[SerializeField]
    //List<Node> _nodes; //node list

    //[SerializeField]
    //public List<Node> _docks; //docks list

    //public Transform nextNode;
    //public Transform nextDock;
    //public float moveSpeed;

    //public int nextNodeIndex = 0;
    //public bool isFinalNode = false; //set default to false

    //public int nextDockIndex = 0;
    //public bool isDocking = false; //set default to false
    //public bool isInDockingRange;

    //private void Start() //get node data
    //{
    //    nextNode = _nodes[nextNodeIndex].transform; //get next node transform in index
    //    nextDock = _docks[nextDockIndex].transform; //get next dock transform in index
    //}

    //private void Update() //move based on node data
    //{
    //    if (Input.GetKeyDown(KeyCode.E) && isInDockingRange == true) //if e is pressed + in range
    //    {
    //        isDocking = true; //dock
    //    }

    //    if (Vector3.Distance(transform.position, nextNode.position) <= 0.5f) //if distance between player + next node is less than .5
    //    {
    //        nextNodeIndex++; //increment
    //        nextNode = _nodes[nextNodeIndex].transform; //get attached object's transform

    //        if (nextNodeIndex == _nodes.Count) //count -- element num ref; 9th element = last
    //        {
    //            isFinalNode = true; //stop when final destination is reached
    //        }
    //    }
    //    if (!isFinalNode) //if destination is not reached + is docking
    //    {
    //        if (isDocking)
    //        {
    //            isMoving(nextDock); //move to next dock
    //        }
    //        else //if destination is not reached + is not docking
    //        {
    //            isMoving(nextNode); //move to next node
    //        }
    //    }
    //}

    //private void isMoving(Transform target)
    //{
    //    Vector3 moveDir = target.position - this.transform.position; //move to next target
    //    moveDir = moveDir.normalized; //reset, mult by 1
    //    Vector3 changeInPos = moveDir * moveSpeed;

    //    changeInPos.y = 0; //exclude vertical movement

    //    this.transform.position += changeInPos;
    //    //this.transform.Rotate(Quaternion.FromToRotation(this.transform.forward, moveDir).eulerAngles); //calculate rotation
    //}
    #endregion
}