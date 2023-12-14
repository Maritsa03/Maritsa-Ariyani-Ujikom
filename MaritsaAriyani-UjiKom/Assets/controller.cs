using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float PlayerSpeed = 5;
    public float rotationSpeed = 5;
    void Update()
    {
        float amtToMove = Input.GetAxis("Horizontal") * PlayerSpeed * Time.deltaTime;
        transform.Translate(Vector3.right * amtToMove, Space.World);
        float rotation = amtToMove * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotation);
    }
}
