﻿using UnityEngine;
using System.Collections;

public class PenguinCamera : MonoBehaviour
{
    public GameObject target;
    public float turnSpeed = .2f;
    public GameObject penguinCamera;
    float cameraAngleX = 180f;
    float cameraAngleY = 0f;
    public float cameraDistance = 3f;
    public Canvas play;
    public Canvas finish;

    //This follows the penguin in the play screen

    public void Start()
    {
        Quaternion arotation = Quaternion.identity;
        Vector3 eua = Vector3.zero;
        eua.y = 360f - cameraAngleY;
        eua.z = 180f;
        eua.x = cameraAngleX;
        arotation.eulerAngles = eua;
        transform.localRotation = arotation;
    }

    void Update()
    {
        if (play.enabled || finish.enabled)
        {
            
            CameraRotation();

            penguinCamera.transform.localPosition = new Vector3(0f, cameraDistance, -4f * cameraDistance);
        }

    }

    public void TargetSet(GameObject aTarget)
    {
        target = aTarget;
    }

    public void CameraRotation()
    {
        Quaternion arotation = Quaternion.identity;
        Vector3 eua = Vector3.zero;
        eua.y = 360f - cameraAngleY;
        eua.z = 180f;
        eua.x = cameraAngleX;
        arotation.eulerAngles = eua;
        transform.localRotation = arotation;
    }

    void FixedUpdate()
    {
        if (play.enabled || finish.enabled)
        {
            transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * 10f);
        }
    }
}
