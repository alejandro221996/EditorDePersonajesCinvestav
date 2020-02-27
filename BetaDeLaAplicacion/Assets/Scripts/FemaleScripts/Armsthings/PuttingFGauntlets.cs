using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingFGauntlets : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject FGauntlet1;
    public GameObject FGauntlet2;
    public GameObject FGauntlet3;
    public void PutFGauntlet(int FGauntletSelected)
    {
        ExportH.SetFGauntlet(FGauntletSelected);
        switch (FGauntletSelected)
        {
            case 1:
                HideFGauntlet();
                FGauntlet1.SetActive(true);
                Debug.Log("Entro a la funcion 1");


                break;
            case 2:
                HideFGauntlet();
                FGauntlet2.SetActive(true);
                Debug.Log("Entro a la funcion 2");
                break;
            case 3:
                HideFGauntlet();
                FGauntlet3.SetActive(true);
                Debug.Log("Entro a la funcion 3");
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
