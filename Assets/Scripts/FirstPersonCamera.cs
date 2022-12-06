using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0; //default to forward facing cam @ start

    bool lockedCursor = true;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false; //hide
        Cursor.lockState = CursorLockMode.Locked; //lock cursor
    }

    // Update is called once per frame
    void Update()
    {
        //collect mouse input
        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        //rotate cam around local x axis (red arrow)
        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f); //clamp value
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

        //rotate cam around local y axis (green arrow)
        player.Rotate(Vector3.up * inputX);
    }
}
