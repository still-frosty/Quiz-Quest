using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBackground : MonoBehaviour
{
  public float rotateSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 0, rotateSpeed, Space.World);
    }
}
