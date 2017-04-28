using UnityEngine;
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
        if (play.enabled)
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                cameraAngleY += Input.GetAxis("Mouse X");
                cameraAngleX += Input.GetAxis("Mouse Y");
            }
            CameraRotationX();
            CameraRotationY();
            cameraDistance = cameraDistance + Time.deltaTime * Input.GetAxis("Mouse ScrollWheel");
            penguinCamera.transform.localPosition = new Vector3(0f, cameraDistance, -4f * cameraDistance);
        }
    }

    public void TargetSet(GameObject aTarget)
    {
        target = aTarget;
    }

    public void CameraRotationX()
    {
        Quaternion arotation = Quaternion.identity;
        Vector3 eua = Vector3.zero;
        eua.y = 360f - cameraAngleY;
        eua.z = 180f;
        eua.x = cameraAngleX;
        arotation.eulerAngles = eua;
        transform.localRotation = arotation;
    }
    public void CameraRotationY()
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
        transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * 10f);
    }
}
