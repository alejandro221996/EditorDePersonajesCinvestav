using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingFEyes : MonoBehaviour
{
    public GameObject FEyes1;
    public GameObject FEyes2;
    public GameObject FEyes3;
    public GameObject FEyes4;
    public GameObject FEyes5;
    public GameObject FEyes6;
    public GameObject FEyes7;
    public GameObject FEyes8;

    public void PutFEyes(int FEyesSelected)
    {
        switch (FEyesSelected)
        {
            case 1:
                HideFEyes();
                FEyes1.SetActive(true);

                break;
            case 2:
                HideFEyes();
                FEyes2.SetActive(true);
                break;
            case 3:
                HideFEyes();
                FEyes3.SetActive(true);
                break;
            case 4:
                HideFEyes();
                FEyes4.SetActive(true);
                break;
            case 5:
                HideFEyes();
                FEyes5.SetActive(true);
                break;
            case 6:
                HideFEyes();
                FEyes6.SetActive(true);
                break;
            case 7:
                HideFEyes();
                FEyes7.SetActive(true);
                break;
            case 8:
                HideFEyes();
                FEyes8.SetActive(true);
                break;
            default:
                break;

        }
    }
    public void HideFEyes()
    {
        FEyes1.SetActive(false);
        FEyes2.SetActive(false);
        FEyes3.SetActive(false);
        FEyes4.SetActive(false);
        FEyes5.SetActive(false);
        FEyes6.SetActive(false);
        FEyes7.SetActive(false);
        FEyes8.SetActive(false);
    }
}
