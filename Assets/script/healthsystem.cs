using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthsystem : MonoBehaviour
{
    public int currenthealth;
    public int maxhealth = 100;

    public healthbar HealthBar;
    void Start()
    {
        currenthealth = maxhealth;
        HealthBar.SetMaxhealth(maxhealth);
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collosion");
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        if (other.gameObject.tag == "damageobject")
        {
            DamagePlayer(10);
        }
    }


    public void DamagePlayer(int damage)
    {
        currenthealth -= damage;

        HealthBar.SetHealth(currenthealth);
    }
}