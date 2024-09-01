using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOfRock : MonoBehaviour
{
    public float RotationRock;

    private void Update()
    {
        transform.Rotate(0, 0, 360 * RotationRock * Time.deltaTime);
    }
}
