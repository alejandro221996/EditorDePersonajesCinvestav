using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingHeadAccesories : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject HFAccess1;
    public GameObject HFAccess2;
    public GameObject HFAccess3;
    public GameObject HFAccess4;
    public GameObject HFAccess5;
    public GameObject HFAccess6;
    public GameObject HFAccess7;
    public GameObject HFAccess8;
    public GameObject HFAccess9;
    public GameObject HFAccess10;
    public GameObject HFAccess11;
    public GameObject HFAccess12;
    //public GameObject HFAccess13;



    public void PutHFAccess(int HFAccessSelected)
    {
        ExportH.SetFHeAccess(HFAccessSelected);
        switch (HFAccessSelected)
        {
            case 1:
                HideHFAccess();
                HFAccess1.SetActive(true);

                break;
            case 2:
                HideHFAccess();
                HFAccess2.SetActive(true);
                break;
            case 3:
                HideHFAccess();
                HFAccess3.SetActive(true);
                break;
            case 4:
                HideHFAccess();
                HFAccess4.SetActive(true);
                break;
            case 5:
                HideHFAccess();
                HFAccess5.SetActive(true);
                break;
            case 6:
                HideHFAccess();
                HFAccess6.SetActive(true);
                break;
            case 7:
                HideHFAccess();
                HFAccess7.SetActive(true);
                break;
            case 8:
                HideHFAccess();
                HFAccess8.SetActive(true);
                break;
            case 9:
                HideHFAccess();
                HFAccess9.SetActive(true);
                break;
            case 10:
                HideHFAccess();
                HFAccess10.SetActive(true);
                break;
            case 11:
                HideHFAccess();
                HFAccess11.SetActive(true);
                break;
            case 12:
                HideHFAccess();
                HFAccess12.SetActive(true);
                break;
            /* case 13:
                 HideHFAccess();
                 HFAccess8.SetActive(true);
                 break;*/

            default:
                break;

        }
    }
    public void HideHFAccess()
    {
        HFAccess1.SetActive(false);
        HFAccess2.SetActive(false);
        HFAccess3.SetActive(false);
        HFAccess4.SetActive(false);
        HFAccess5.SetActive(false);
        HFAccess6.SetActive(false);
        HFAccess7.SetActive(false);
        HFAccess8.SetActive(false);
        HFAccess9.SetActive(false);
        HFAccess10.SetActive(false);
        HFAccess11.SetActive(false);
        HFAccess12.SetActive(false);
        //HFAccess13.SetActive(false);

    }
}
