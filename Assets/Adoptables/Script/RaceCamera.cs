using UnityEngine;
using System.Collections;

public class RaceCamera : MonoBehaviour
{
    public GameObject target;
    public float turnSpeed = .2f;
    public GameObject raceCamera;
    float cameraAngleX = 180f;
    float cameraAngleY = 0f;
    public float cameraDistance = 3f;
    public Canvas race;

    // This follows your penguin in the race

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
        if (race.enabled)
        {
            CameraRotation();

            raceCamera.transform.localPosition = new Vector3(0f, cameraDistance, -10f * cameraDistance);
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
        eua.y = 270f - cameraAngleY;
        eua.z = 180f;
        eua.x = -25f + cameraAngleX;
        arotation.eulerAngles = eua;
        transform.localRotation = arotation;
    }
    
    void FixedUpdate()
    {
        if (race.enabled)
        {
            transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * 10f);
        }
    }
}
