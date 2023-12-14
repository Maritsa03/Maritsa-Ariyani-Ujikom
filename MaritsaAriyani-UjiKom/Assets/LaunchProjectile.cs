using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public float BlastPower = 5;

    public GameObject Food;
    public Transform ShotPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject CreatedFood = Instantiate(Food, ShotPoint.position, ShotPoint.rotation);
            damage spawnedFood = CreatedFood.GetComponent<damage>();
            CreatedFood.GetComponent<Rigidbody>().velocity = ShotPoint.transform.forward * BlastPower;
        }
    }
}
