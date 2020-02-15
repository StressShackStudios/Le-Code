﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeadCam : MonoBehaviour
{
    Vector2 mouseLook;
    Vector2 smoothV;
    public float Sensitivity = 5f;
    public float Smoothing = 2f;
    GameObject Player;
    void Start()
    {
        Player = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(Sensitivity * Smoothing, Sensitivity * Smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / Smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / Smoothing);
        mouseLook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        Player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, Player.transform.up);
    }
}