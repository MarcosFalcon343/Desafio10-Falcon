using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] PlayerCannosManager cannontype;
    
    //Script para el player al presionar espacio dispare
    [SerializeField] GameObject[] bullets;
    [SerializeField] Transform[] typeCannon;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                spawnBulllet();
            }
        
    }

    private void spawnBulllet()
    {
        if(cannontype.CannonP == true)
        {
            Instantiate(bullets[0], typeCannon[0]);
            Instantiate(bullets[0], typeCannon[1]);
        }
        if(cannontype.CannonMisile == true)
        {
            Instantiate(bullets[1], typeCannon[2]);
            Instantiate(bullets[1], typeCannon[3]);
        }
        if(cannontype.CannonRay == true)
        {
            Instantiate(bullets[2], typeCannon[4]);
        }
    }

    
}
