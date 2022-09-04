using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour

{
    [SerializeField] PlayerPowerUp PlayerPowerup;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision con: " + other.gameObject.name);
        if (other.gameObject.CompareTag("PowerUp"))
        {
            PlayerPowerup.PowerUpList.Add(other.gameObject.name);
            other.gameObject.SetActive(false);
        }
    }

}
