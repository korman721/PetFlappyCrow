using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdRotation : MonoBehaviour
{

    [SerializeField] private float RotationSpeed;
    [SerializeField] private float TakeOffRotation, LandingRotation;

    public float rotZ;

    public void StartRotation()
    {
        rotZ = TakeOffRotation;
    }

    public void ApplyRotation(float VelocytyY)
    {
        if (rotZ > LandingRotation)
        {
            float offset = 1f;
            VelocytyY = Mathf.Abs(VelocytyY);
            if (VelocytyY > 0.5f) offset = VelocytyY;
            offset = Mathf.Abs(offset);

            rotZ -= RotationSpeed * Time.deltaTime / offset;
            transform.localEulerAngles = new Vector3(0, 0, rotZ);
        }
    }
}
