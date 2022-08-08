using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCircleMovement : MonoBehaviour
{
    public float rotationSpeed = 5f;

    private void Update() 
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
