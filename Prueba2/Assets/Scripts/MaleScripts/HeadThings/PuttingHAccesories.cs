using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingHAccesories : MonoBehaviour
{
    public GameObject HAccess1;
    public GameObject HAccess2;
    public GameObject HAccess3;
    public GameObject HAccess4;
    public GameObject HAccess5;
    public GameObject HAccess6;
    public GameObject HAccess7;
    public GameObject HAccess8;
    public GameObject HAccess9;

    public void PutHAcess(int HAccessSelected)
    {
        switch (HAccessSelected)
        {
            case 1:
                HideHAcess();
                HAccess1.SetActive(true);

                break;
            case 2:
                HideHAcess();
                HAccess2.SetActive(true);
                break;
            case 3:
                HideHAcess();
                HAccess3.SetActive(true);
                break;
            case 4:
                HideHAcess();
                HAccess4.SetActive(true);
                break;
            case 5:
                HideHAcess();
                HAccess5.SetActive(true);
                break;
            case 6:
                HideHAcess();
                HAccess6.SetActive(true);
                break;
            case 7:
                HideHAcess();
                HAccess7.SetActive(true);
                break;
            case 8:
                HideHAcess();
                HAccess8.SetActive(true);
                break;
            case 9:
                HideHAcess();
                HAccess9.SetActive(true);
                break;
            default:
                break;

        }
    }
    public void HideHAcess()
    {
        HAccess1.SetActive(false);
        HAccess2.SetActive(false);
        HAccess3.SetActive(false);
        HAccess4.SetActive(false);
        HAccess5.SetActive(false);
        HAccess6.SetActive(false);
        HAccess7.SetActive(false);
        HAccess8.SetActive(false);
        HAccess9.SetActive(false);
    }
}
