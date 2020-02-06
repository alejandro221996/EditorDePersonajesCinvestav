using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingFGauntlets : MonoBehaviour
{
    public GameObject FGauntlet1;
    public GameObject FGauntlet2;
    public GameObject FGauntlet3;
    public void PutFGauntlet(int FGauntletSelected)
    {
        switch (FGauntletSelected)
        {
            case 1:
                HideFGauntlet();
                FGauntlet1.SetActive(true);
               

                break;
            case 2:
                HideFGauntlet();
                FGauntlet2.SetActive(true);

                break;
            case 3:
                HideFGauntlet();
                FGauntlet3.SetActive(true);

                break;
            default:
                break;
        }
    }
    public void HideFGauntlet()
    {
        FGauntlet1.SetActive(false);
        FGauntlet2.SetActive(false);
        FGauntlet3.SetActive(false);
    }
}
