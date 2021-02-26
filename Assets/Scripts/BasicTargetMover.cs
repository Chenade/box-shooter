using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
    public bool isSpin = true;
    public float spinSpped = 180.0f;

    public bool isMotion = false;
    public float motionMagnitude = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (isSpin)
        {
            transform.Rotate(Vector3.up * spinSpped * Time.deltaTime);
        }

        if (isMotion)
        {
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }
    }
}
