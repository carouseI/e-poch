using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    #region wasd
    //[SerializeField] float speed;

    //private Vector3 currentPosition;

    //// Update is called once per frame
    //void Update()
    //{
    //    Movement();
    //}

    //public void Movement()
    //{
    //    if (Input.GetKey(KeyCode.Z)) currentPosition.z += speed * Time.deltaTime; //w
    //    if (Input.GetKey(KeyCode.S)) currentPosition.z -= speed * Time.deltaTime; //s
    //    if (Input.GetKey(KeyCode.D)) currentPosition.x += speed * Time.deltaTime; //d
    //    if (Input.GetKey(KeyCode.Q)) currentPosition.x -= speed * Time.deltaTime; //a

    //    transform.position = currentPosition;
    //}
    #endregion

    [SerializeField] float moveSpeed = 1f;
    //public static int moveSpeed = 1f;
    public Vector3 boatDirection = Vector3.forward;

    public void Update()
    {
        transform.Translate(boatDirection * moveSpeed * Time.deltaTime);
    }
}