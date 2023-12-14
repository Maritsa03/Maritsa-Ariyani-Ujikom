using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform waypoint;
    public float speed = 5f;
    
    private health player;
    public int maxHP = 10;
    int currentHP;
    //------------Death------------
    protected bool dead=true;
	public event System.Action OnDeath;
    public void Start()
    {
        currentHP = maxHP;
        player=GameObject.Find("Player").GetComponent<health>();
    }
    public void DamageEnemy(int damageAmount)
    {
        currentHP -= damageAmount;
        //Debug.Log("Enemy"+currentHP);
        if (currentHP <= 0 && !dead)
        {
            Die();
        } else 
        {
            //Debug.Log("dor");
        }
    }
    protected void Die() 
    {
		dead = true;
		if (OnDeath != null) {
			OnDeath();
		}
		GameObject.Destroy (gameObject);
        GetComponent<Collider>().enabled=false;
	}
    void Update()
    {
        if (waypoint != null)
        {
            // Calculate the direction towards the waypoint
            Vector3 direction = waypoint.position - transform.position;

            // Normalize the direction to get a unit vector
            direction.Normalize();

            // Move the GameObject towards the waypoint
            transform.Translate(direction * speed * Time.deltaTime);
        }
        else
        {
            Debug.LogError("Waypoint not assigned!");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            //Debug.Log("HitPlayer!");
            other.GetComponent<health>().TakeDamage(5);
        }
    }
}
