using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterMovementScript : MonoBehaviour {

    public float walk_Speed = 5.0f;
    public float SensitivityY = 10.0f;
    public float SensitivityX = 10.0f;

    HunterControllerScript controller;

    private void Start()
    {
        controller = GetComponent<HunterControllerScript>();
    }

    private void Update()
    {
        float xPos = Input.GetAxisRaw("Horizontal");
        float zPos = Input.GetAxisRaw("Vertical");

        Vector3 move_Horizontal = transform.right * xPos;
        Vector3 move_Vertical = transform.forward * zPos;

        Vector3 _velocity = (move_Horizontal + move_Vertical).normalized * walk_Speed;

        controller.GetVeloc(_velocity);

        float xRotate = Input.GetAxisRaw("Mouse X");
        float yRotate = Input.GetAxisRaw("Mouse Y");

        Vector3 _lookAround = new Vector3(0, xRotate, 0) * SensitivityX;
        Vector3 _rotateCam = new Vector3(yRotate, 0, 0) * SensitivityY;

        controller.GetLookAround(_lookAround, _rotateCam);

    }
}
