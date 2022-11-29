using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Camera cam;

    private Vector3 previousPosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //0 = left button
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 direction = previousPosition - cam.ScreenToViewportPoint(Input.mousePosition); //store distance moved since last frame in viewport coords

            cam.transform.position = new Vector3(); //reset cam pos to 0, 0, 0 — pivot/rotate point

            //cam.transform.Rotate(new Vector3(1, 0, 0), direction.y * 180); //apply rotation to x axis
            cam.transform.Rotate(new Vector3(0, 1, 0), -direction.x * 180, Space.World); //apply rotation to y axis
            cam.transform.Translate(new Vector3(0, 0, -10));

            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
    }
}
