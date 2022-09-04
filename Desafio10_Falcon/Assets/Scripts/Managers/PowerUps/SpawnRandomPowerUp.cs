using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomPowerUp : MonoBehaviour
{

    [SerializeField] GameObject[] powerUp;
    private int ramdomNumber;
    private Vector3 newposition;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("instanciarPowerUp", 2f, 30f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void instanciarPowerUp()
    {
        ramdomNumber = Random.Range(0, powerUp.Length);
        newposition = new Vector3(Random.Range(-40f, 40f), 2, Random.Range(-40f, 40f));
        Instantiate(powerUp[ramdomNumber], newposition, new Quaternion());
    }
}
