using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUp : MonoBehaviour
{
    //[SerializeField] GameObject[] powerUp;

    [SerializeField] List<string> powerUpList;

    public List<string> PowerUpList { get => powerUpList; set => powerUpList = value; }

    // Start is called before the first frame update
    void Start()
    {
        powerUpList = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
