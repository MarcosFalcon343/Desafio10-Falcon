using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCannosManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] cannos;

    [SerializeField] Transform cannon;
    [SerializeField] Transform cannon2;
    [SerializeField] Transform misilecannon;
    [SerializeField] Transform misilecannon2;
    [SerializeField] Transform rayCannon;

     private int cannonStage = 0;
    [SerializeField]private bool cannonP = true;
    [SerializeField]private bool cannonMisile = false;
    [SerializeField]private bool cannonRay = false;

    public bool CannonP { get => cannonP; set => cannonP = value; }
    public bool CannonMisile { get => cannonMisile; set => cannonMisile = value; }
    public bool CannonRay { get => cannonRay; set => cannonRay = value; }

    void Start()
    {
        cannos[0].SetActive(true);
        cannos[1].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) changeCannons();
    }

    void changeCannons()
    {
        if(cannonStage >= 2)
        {
            cannonStage = 0;
        }
        else
        {
            cannonStage++;
        }
        
        switch (cannonStage)
        {
            case 0:
                cannonRay = changeStage(cannonRay);
                rayActivate(cannonRay);
                cannonP = changeStage(cannonP);
                principalBulletActivate(cannonP);
                break;
            case 1:
                cannonP = changeStage(cannonP);
                principalBulletActivate(cannonP);
                cannonMisile = changeStage(cannonMisile);
                miseleActivate(cannonMisile);
                break;
            case 2:
                cannonMisile = changeStage(cannonMisile);
                miseleActivate(cannonMisile);
                cannonRay = changeStage(cannonRay);
                rayActivate(cannonRay);
                break;
        }
    }

    void principalBulletActivate(bool stage)
    {
        cannos[0].SetActive(stage);
        cannos[1].SetActive(stage);
    }
    void miseleActivate(bool stage)
    {
        cannos[2].SetActive(stage);
        cannos[3].SetActive(stage);
    }

    void rayActivate(bool stage)
    {
        cannos[4].SetActive(stage);
    }

    bool changeStage(bool stage)
    {
        return !stage;
    }

   
}
