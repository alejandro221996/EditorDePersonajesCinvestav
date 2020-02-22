using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingFPants : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject FPant1;
    public GameObject FPant2;

    public void PutFPant(int FPantSelected)
    {
        ExportH.SetFPants(FPantSelected);
        switch (FPantSelected)
        {
            case 1:
                HideFPant();
                FPant1.SetActive(true);


                break;
            case 2:
                HideFPant();
                FPant2.SetActive(true);

                break;



            default:
                break;
        }
    }
    public void HideFPant()
    {
        FPant1.SetActive(false);
        FPant2.SetActive(false);

    }
}
