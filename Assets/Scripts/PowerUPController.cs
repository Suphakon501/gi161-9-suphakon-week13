using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUPController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            PowerUp powerUP = GetComponent<PowerUp>();

            if (powerUP != null && player != null)
            {
                powerUP.ApplyPowerUp(player);
                Destroy(gameObject);
            }
        }
    }
}