using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement =transform.parent.gameObject.GetComponent<PlayerMovement>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.LogError("Enemy!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            playerMovement.TakeDamage(1.0f);
        }
        else if (other.tag =="Gold")
        {
            playerMovement.CollectGold();
            Destroy(other.gameObject);
        }
        else if (other.tag =="Collectable")
        {
            playerMovement.CollectableAdd();
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag =="Magma")
        {
            playerMovement.TakeDamage(0.01f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
