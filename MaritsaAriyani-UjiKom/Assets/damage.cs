using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Enemy")
        {
            Debug.Log("HitENEMY!");
            other.GetComponent<enemy>().DamageEnemy(10);
        }
    }
}
