using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingFHats : MonoBehaviour
{
    public GameObject FHat1;
    public GameObject FHat2;
    public GameObject FHat3;
    public GameObject FHat4;
    public GameObject FHat5;
    public GameObject FHat6;
    public GameObject FHat7;

    public void PutFHat(int FHatSelected)
    {
        switch (FHatSelected)
        {
            case 1:
                HideFHats();
                FHat1.SetActive(true);

                break;
            case 2:
                HideFHats();
                FHat2.SetActive(true);
                break;
            case 3:
                HideFHats();
                FHat3.SetActive(true);
                break;
            case 4:
                HideFHats();
                FHat4.SetActive(true);
                break;
            case 5:
                HideFHats();
                FHat5.SetActive(true);
                break;
            case 6:
                HideFHats();
                FHat6.SetActive(true);
                break;
            case 7:
                HideFHats();
                FHat7.SetActive(true);
                break;

            default:
                break;

        }
    }
    public void HideFHats()
    {
        FHat1.SetActive(false);
        FHat2.SetActive(false);
        FHat3.SetActive(false);
        FHat4.SetActive(false);
        FHat5.SetActive(false);
        FHat6.SetActive(false);
        FHat7.SetActive(false);
    }
}
