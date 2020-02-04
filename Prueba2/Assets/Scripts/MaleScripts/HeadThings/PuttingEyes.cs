using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingEyes : MonoBehaviour
{
    public GameObject Eyes1;
    public GameObject Eyes2;
    public GameObject Eyes3;
    public GameObject Eyes4;
    public GameObject Eyes5;
    public GameObject Eyes6;
    public GameObject Eyes7;
    public GameObject Eyes8;

    public void PutEyes(int EyesSelected)
    {
        switch (EyesSelected)
        {
            case 1:
                HideEyes();
                Eyes1.SetActive(true);

                break;
            case 2:
                HideEyes();
                Eyes2.SetActive(true);
                break;
            case 3:
                HideEyes();
                Eyes3.SetActive(true);
                break;
            case 4:
                HideEyes();
                Eyes4.SetActive(true);
                break;
            case 5:
                HideEyes();
                Eyes5.SetActive(true);
                break;
            case 6:
                HideEyes();
                Eyes6.SetActive(true);
                break;
            case 7:
                HideEyes();
                Eyes7.SetActive(true);
                break;
            case 8:
                HideEyes();
                Eyes8.SetActive(true);
                break;
            default:
                break;

        }
    }
    public void HideEyes()
    {
        Eyes1.SetActive(false);
        Eyes2.SetActive(false);
        Eyes3.SetActive(false);
        Eyes4.SetActive(false);
        Eyes5.SetActive(false);
        Eyes6.SetActive(false);
        Eyes7.SetActive(false);
        Eyes8.SetActive(false);
    }
}
