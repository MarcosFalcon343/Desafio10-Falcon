using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPowerUp : MonoBehaviour
{

    public float destroyTime = 30f;
    void Start()
    {
        Invoke("destroyDelay", destroyTime);
    }

    private void destroyDelay()
    {
        Destroy(gameObject);
    }
}
